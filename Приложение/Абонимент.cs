//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Приложение
{
    using System;
    using System.Collections.Generic;
    
    public partial class Абонимент
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Абонимент()
        {
            this.Аквапарк = new HashSet<Аквапарк>();
        }
    
        public int id_абонимента { get; set; }
        public Nullable<int> id_клиента { get; set; }
        public System.DateTime Дата_регистрации { get; set; }
        public System.DateTime Дата_окончания { get; set; }
        public bool Взрослый { get; set; }
        public bool Детский { get; set; }
    
        public virtual Клиент Клиент { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аквапарк> Аквапарк { get; set; }
    }
}
