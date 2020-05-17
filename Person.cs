using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UAS
{
    class Person 
    {
        // ini adalah atribut untuk Person
        private string noKtp;
        private string nama;
        private string alamat;

        #region **
        // **. Buatkan Properties untuk setiap atribut
        // ........................... YOUR CODE IS HERE ------------- 
        public string NoKtp 
        {
            get { return this.noKtp; }
            set { this.noKtp = value; }
        }
        public string Nama
        {
            get { return this.nama; }
            set { this.nama = value; }
        }
        public string Alamat
        {
            get { return this.alamat; }
            set { this.alamat = value; }
        }
        #endregion
    }
}
