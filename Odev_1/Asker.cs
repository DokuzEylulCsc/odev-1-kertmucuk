using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } } //kordinata ulaşıp değiştirmek için set ekledim

        private bool OlduMu = true; //yasadiğini öğprenmek icin
        private int Cani = 100;//caninin kaç oldugunu baştan 100 belittik
        // ..... //

        public int Canli { get { return Cani; }; set { Cani = value; } } //caninin kac oldugunu erişmek için çünkü class abstract
        public bool YasiyorMu { get { return OlduMu; } set { OlduMu = value; } } // canli olup olmadıgını erişmek için çünkü class abstract
        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void AtesEt();
        // ..... //

    }
}
