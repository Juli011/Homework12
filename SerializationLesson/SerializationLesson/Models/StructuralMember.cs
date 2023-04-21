﻿using AbstactClass.Const;

namespace AbstactClass.Models
{
    public abstract class StructuralMember
    {
        protected Material material { get; }
        
        private int E_Puasson(Material material)
        {
            if (this.material==Material.Steel)
            {
                return 27000000;
            }
            else if (this.material==Material.Concrete)
            {
                return 3000000;
            }
            else
            {
                return 27000000;
            }
            
        }
        protected int E { get; }

        public StructuralMember()
        {

        }
        public StructuralMember(Material material)
        {
            this.material = material;
            E = E_Puasson(material);
        }
        
        protected abstract double InertiaMoment();
       
        public virtual void Message(bool a)
        {
            Console.WriteLine("This is abstact class of StructuralMember");
        }
    }
}
