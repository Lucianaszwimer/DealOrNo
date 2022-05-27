using System;
using System.Collections.Generic;
namespace DealOrNoDeal.Models
{
    public static class DealOrNo
    {
        public static List<double> ImportesDescartados = new List<double>();
        private static Maletin[] _Maletines;
        private static Maletin _MaletinElegido;
        private static int[] _Importes;
        private static int _Jugadas;
        private static int _Turno;
        private static double _Oferta;

        public static void IniciarJuego(int MaletinEle)
        {
            _Jugadas = 6;
             _Turno = 8; 
             
             _Importes = new int[26] { 1, 5, 10, 15, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000}; 
             _Maletines = new Maletin[26]; 
            for(int i=0;i<26;i++)
            {
                Random rnd=new Random();
                int nro = rnd.Next(0,26);
                while (_Importes[nro]==-1)
                {
                    nro = rnd.Next(0,26);
                }
                Maletin MaletinTemporal = new Maletin(i,_Importes[nro]);
                _Maletines[i] = MaletinTemporal;
                _Importes[nro] = -1;
            }
            _MaletinElegido = _Maletines[MaletinEle];
            _MaletinElegido.Estado=true;; 
        
    }


    public static double AbrirMaletin(int Numero)
    {
        if (_Maletines[Numero].Estado == false)
        {
            _Maletines[Numero].Estado = true;
            _Jugadas--;
            ImportesDescartados.Add(_Maletines[Numero].Importe);
            return _Maletines[Numero].Importe;
        }
        else
        {
            return -1;
        }
        //Recibe un numero de MAletin para abrir
        // Se fija si ese numero de maletin no fue abierto previamente
        // si fue abiero devuelvo -1
        // sino cambio estado a abierto, descuento jugadas y retorno el importe de ese maletin 
    }
    public static int JugadasRestantes()
    {
        return _Jugadas;
    }

    public static int TurnosRestantes()
    {
        return _Turno;
    }
    public static Maletin MaletinElegido()
    {
        return _MaletinElegido;
    }
    public static double OfertaBanca()
    {
        double acumulador=0;
        _Oferta=0;
        int contador = 0;
        for (int j = 0; j < 26; j++)
        {
            if (_Maletines[j].Estado == false)
            {
                acumulador = acumulador + _Maletines[j].Importe;
                contador++;
            }
            _Oferta = (acumulador / contador) * 0.85;
        }
        return _Oferta;
    }

    public static double DecisionOferta(string Aceptar)
    {
        if (Aceptar == "true")
        {
            return _MaletinElegido.Importe;
        }
        else
        {
            _Turno--;
            if(_Turno<=2){
                _Jugadas=1;
            }else{
                _Jugadas=_Turno-2;
            }
            return -1;
        }
    }

    public static Maletin[] ListaMaletines()
    {
        return _Maletines;
    }

    public static int[] ListaImportes()
    {
        _Importes = new int[26] { 1, 5, 10, 15, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        return _Importes;
    }



}
}
