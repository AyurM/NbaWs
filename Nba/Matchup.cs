//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nba
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Matchup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Matchup()
        {
            this.MatchupDetails = new ObservableCollection<MatchupDetail>();
            this.MatchupLogs = new ObservableCollection<MatchupLog>();
        }
    
        public int MatchupId { get; set; }
        public int SeasonId { get; set; }
        public int MatchupTypeId { get; set; }
        public int Team_Away { get; set; }
        public int Team_Home { get; set; }
        public System.DateTime Starttime { get; set; }
        public int Team_Away_Score { get; set; }
        public int Team_Home_Score { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string CurrentQuarter { get; set; }
    
        public virtual MatchupType MatchupType { get; set; }
        public virtual Season Season { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<MatchupDetail> MatchupDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<MatchupLog> MatchupLogs { get; set; }
    }
}