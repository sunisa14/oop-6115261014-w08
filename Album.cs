using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w08
    {
    class Album
    {
        private string albumCode;
        private string albumName;
        private string albumDate;
        private string albumType;
        private  Img   albumImg ;
        public string AlbumCode
        {
            get { return this.albumCode; }
            set { this.albumCode = value; }
        }
        public string AlbumName
        {
            get { return this.albumName; }
            set { this.albumName = value; }
        }
        public string AlbumDate
        {
            get { return this.albumDate; }
            set { this.albumDate = value; }
        }

        public string AlbumType
        {
            get { return this.albumType; }
            set { this.albumType = value; }
        }
        public  Img AlbumImg
        {
            get { return this.albumImg; }
            set { this.albumImg = value; }
        }

        public Album() { }
        public Album(string ac, string an, string ad, string at,Img aim)
        {
            this.AlbumCode = ac;
            this.AlbumName = an;
            this.AlbumDate = ad;
            this.AlbumType = at;
            this.AlbumImg = aim;
        }
        public override string ToString()
        {
            return this.AlbumCode + " " + this.AlbumName + " " + this.AlbumDate + " " + this.AlbumType  + this.AlbumImg.ToString()
               + " " + this.AlbumImg.ImgWite + " "  + this.AlbumImg.ImgLength + " " + this.AlbumImg.ImgDate;
        }
    }
}