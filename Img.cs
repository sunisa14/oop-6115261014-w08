using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w08
    { 
    class Img
    {
        private string imgName;
        private string imgWite;
        private string imgLength;
        private string imgDate;
        private string imgType;
        public string ImgName
    {
            get { return this.imgName; }
            set { this.imgName = value; }
        }
        public string ImgWite
        {
            get { return this.imgWite; }
            set { this.imgWite = value; }
        }
        public string ImgLength
        {
            get { return this.imgLength; }
            set { this.imgLength = value; }
        }
        public string ImgDate
        {
            get { return this.imgDate; }
            set { this.imgDate = value; }
        }
        public string ImgType
        {
            get { return this.imgType; }
            set { this.imgType= value; }
        }
       
        public Img() { }
        public Img(string ine, string iwe, string ilh, string idt, string itp)
        {
            this.ImgName = ine;
            this.ImgWite = iwe;
            this.ImgLength = ilh;
            this.ImgDate = idt;
            this.ImgType   = itp;
        }
        public override string ToString()
        {
            return this.ImgName + " " + this.ImgType; 
        
         }
    }
}