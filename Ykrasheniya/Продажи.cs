//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ykrasheniya
{
    using System;
    using System.Collections.Generic;
    
    public partial class Продажи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продажи()
        {
            this.ПродукцияВПродажах = new HashSet<ПродукцияВПродажах>();
        }
    
        public int КодПродажи { get; set; }
        public System.DateTime Дата { get; set; }
        public decimal Стоимость { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ПродукцияВПродажах> ПродукцияВПродажах { get; set; }
    }
}
