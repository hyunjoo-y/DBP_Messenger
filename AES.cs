﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace on_off_proj
{
    static class AES
    {
        //
        /// <returns>암호화 된 데이터</returns>
        private static string EncryptString(string plainText, string cipherKey)
        {
            // class 선언, 초기화
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            // 입력 받은 문자열을 바이트 배열로 변환
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(plainText);

            //딕셔너리 공격을 대비해서 키를 더 풀기 어렵게 만들기 위해서 Salt를 사용한다.
            byte[] Salt = Encoding.ASCII.GetBytes(cipherKey.Length.ToString());

            //PasswordDeriveBytes 클래스를 사용해서 SecretKey를 얻는다.
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(cipherKey, Salt);

            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            //메모리 스트림 객체를 선언, 초기화
            MemoryStream memoryStream = new MemoryStream();

            //CryptoStream 객체를 암호화 된 데이터를 쓰기 위한 용도로 선언
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);

            //암호화 프로세스가 진행된다.
            cryptoStream.Write(PlainText, 0, PlainText.Length);

            //암호화 종료
            cryptoStream.FlushFinalBlock();

            //암호화 된 데이터를 바이트 배열로 담는다.
            byte[] CipherBytes = memoryStream.ToArray();

            //스트림 해제
            memoryStream.Close();
            cryptoStream.Close();

            //암호화 된 데이터를 base64 인코딩 된 문자열로 변환한다.
            string EncryptedData = Convert.ToBase64String(CipherBytes);

            //최종 결과를 리턴
            return EncryptedData;
        }

        /// 복호화
        private static string DecryptString(string encryptData, string cipherKey)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            byte[] EncryptedData = Convert.FromBase64String(encryptData);
            byte[] Salt = Encoding.ASCII.GetBytes(cipherKey.Length.ToString());


            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(cipherKey, Salt);

            //Decryptor 객체를 만든다
            ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

            MemoryStream memoryStream = new MemoryStream(EncryptedData);

            //데이터 읽기(복호화이므로) 용도로 cryptoStream객체를 선언, 초기화
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

            //복호화 된 데이터를 담을 바이트 배열을 선언한다.
            // 길이는 알 수 없지만, 암호화 된 데이터 길이보다는 적을 것이기에 그 길이로 선언한다.
            byte[] PlainText = new byte[EncryptedData.Length];

            //복호화 시작
            int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);

            memoryStream.Close();
            cryptoStream.Close();

            //복호화 된 데이터를 문자열로 바꾼다.
            string DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);

            return DecryptedData;

        }


        public static string Encryption(string Encryption_sentence, string db_encryption_key)
        {
            // 암호화
            string encryptKey = Encryption_sentence;  // 암호화 할 평문
            string password = db_encryption_key;   // 비밀키
            string enc = EncryptString(encryptKey, password);  //암호화 함수 호출
            return enc;

        }
        public static string Decryption(string enc, string password)
        {
            //복호화
            string decryptKey = enc;   // 복호화 할 암호화 키
            string dec = DecryptString(decryptKey, password);  //복호화 함수 호출
            return dec;
        }
    }
}
