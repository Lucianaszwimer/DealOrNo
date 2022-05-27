using System;
namespace DealOrNoDeal.Models
{
    public class Maletin
    {
       private int _NumeroDeMaletin;
       private double _Importe;
       private bool _Estado;

       public int NumeroDeMaletin{
           get{
               return _NumeroDeMaletin;
           }
        }
        public double Importe{
            get{
                return _Importe;
               }
        }
        public bool Estado{
           get{
               return _Estado;
            }
            set{
                _Estado = value;
            }
        }

        public Maletin(int NumeroDeMaletin, double Importe){

       _NumeroDeMaletin = NumeroDeMaletin;
       _Importe = Importe;       
       _Estado = false;

       }
    }
}
