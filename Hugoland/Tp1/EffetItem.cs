//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class EffetItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int ValeurEffet { get; set; }
        public int TypeEffet { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
