using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDMU2.Model
{
    public class ElBil : Bil, IElBil
    {

        //props

        public int BatteriKapacitet { get; set; }
        public int KmPrKW { get; set; }



        // ctor
        public ElBil(string mærke, int købsår, double bilPrisExAfgift, int BatteriKapacitet, int KmPrKW) : base(mærke, købsår, bilPrisExAfgift)
        {
            this.BatteriKapacitet = BatteriKapacitet;
            this.KmPrKW = KmPrKW;
        }


        // method
        public override double HalvÅrligEjeafgift()
        {
            return 0;
        }

        public override double RegistreringAfgift()
        {
            return base.RegistreringAfgift() * 0.20;
        }

        public override double RækkeVidde()
        {
            return BatteriKapacitet * KmPrKW;
        }


        public int LadeTid()
        {
            return 5;
        }

        public override string ToString()
        {
            return $"Mærke = {Mærke} \nKøbs år = {KøbsÅr} \nPris = {TotalPris()} \nRække vidde = {RækkeVidde()} \nEjer afgift {HalvÅrligEjeafgift()} \n Lade tid = {LadeTid()} \n Regafgift = {RegistreringAfgift()}";
        }
        
    }
}
