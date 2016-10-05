using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotModular
{
    public class clsVars
    {
        
        //Variable K
        private int varK;
        
        public int K
        {
            get { return varK; }
            set { varK = value; }
        }

        private int varKa;

    	public int Ka
	{
		get { return varKa;}
		set { varKa = value;}
	}
	

        //Variable A
        private int varA;

        public int A
        {
            get { return varA; }
            set { varA = value; }
        }

        private int varAa;

	    public int Aa
	{
		get { return varAa;}
		set { varAa = value;}
	}
	
        //Variable C
        private int varC;

        public int C
        {
            get { return varC; }
            set { varC = value; }
        }
        
        private int varCa;

	    public int Ca
	{
		get { return varCa;}
		set { varCa = value;}
	}
	

        //Variable N
        private int varN;

        public int N
        {
            get { return varN; }
            set { varN = value; }
        }
        

        //Funciones
        public int NextK(int Ka)
        {
            Ka=K;

            if((Ka%2)==0)
            {
                return Ka/2;
            }
            else
            {
                return ((Ka - 1) / 2);
            }
        }

        public int NextA(int Aa)
        {
            Aa = A;
            return (Convert.ToInt32(Math.Pow(Convert.ToDouble(Aa), 2))) % N; 
        }
        
        public int NextC(int Aa,int Ka,int Ca)
        {
            Ca = C;
            Ka = K;
           
            if ((Ka%2)==0)
            {
                return Ca;
            }
            else
            {
                Aa = A;
                return (Ca*Aa)%N;
            }
        }
        
        public int Resultado(int C, int A)
        {
            return (C * A) % N;
        }
    }
}
