using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UAS
{
    #region **
    // Teller diturunkan dari class Person 
    #endregion
    class Teller : Person
    {
        private string kodePegawai;
        private string nomorTeller;

        #region **
        // **. Buat PROPERTIES dari atribut private Teller
        // ........................... YOUR CODE IS HERE ------------- 
        public string KodePegawai 
        { 
            get {return this.kodePegawai;}
            set { this.kodePegawai = value; }
        }
        public string NomorTeller
        {
            get { return this.nomorTeller; }
            set { this.nomorTeller = value; }
        }
        #endregion

        #region **
        // **. Buat constructor untuk teller
        // parameter = nomorKTP, KodePegawai, nama, alamat, nomorteller
        
        public Teller(string _noKTP, string _nama, string _alamat, string _kodPegawai, string _nomorTeller)
        {
            // ........................... YOUR CODE IS HERE ------------- 
            this.NoKtp = _noKTP;
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.kodePegawai = _kodPegawai;
            this.nomorTeller = _nomorTeller;  
        }
        #endregion
    }
}
