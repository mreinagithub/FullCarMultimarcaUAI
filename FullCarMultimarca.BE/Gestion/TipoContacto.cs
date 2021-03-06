using FullCarMultimarca.Abstracciones;
using FullCarMultimarca.Servicios.Extensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCarMultimarca.BE.Gestion
{
    public class TipoContacto : IAuditable, IComparable
    {

        public TipoContacto()
        {

        }
        ~TipoContacto()
        {

        }       
    
          
        public string Descripcion { get; set; }        
        public string ExpresionValidacion { get; set; }        
        public string TextoAyuda { get; set; }
        public bool Activo { get; set; }        
        public bool PermiteNotificaciones { get; set; }

        public override string ToString()
        {
            return $"{Descripcion}";
        }
        public override bool Equals(object obj)
        {
            if (this.Descripcion == null)
                return false;
            else if (obj == null || !(obj is TipoContacto))
                return false;
            return this.Descripcion.EqualsAICI(((TipoContacto)obj).Descripcion);
        }
        public override int GetHashCode()
        {
            return Descripcion != null ? Descripcion.GetHashCode() : base.GetHashCode();
        }
        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(((TipoContacto)obj).ToString());
        }

    }
}
