using System;

namespace Exercise5
{
    class Program
    {
        
    }
    class ComplexNumber
    {

        protected int real;
        protected int imaginary;

        public int getReal()
        {
            return this.real;
        }
        public void setReal(int real)
        {
            this.real = real;
        }
        public int getImaginary()
        {
            return this.imaginary;
        }
        public void setImaginary(int imaginary)
        {
            this.imaginary = imaginary;
        }
        public ComplexNumber()
        {
            this.real = 0;
            this.imaginary = 0;
        }
        public ComplexNumber(int Real,int Imaginary)
        {
            this.real = Real;
            this.imaginary = Imaginary;
        }
        public string ToString()
        {
            return "(" + this.real + "," + this.imaginary + ")";
        }
        public int getMagnitude()
        {
            return real * real + imaginary * imaginary;
        }
        public void Add(ComplexNumber complexNumber)
        {
            this.real = this.real + complexNumber.real;
            this.imaginary = this.imaginary + complexNumber.imaginary;
        }
    }
}
