using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entity
{
    /// <summary> Базовая сущность (Id, ObjectCreateDate, ObjectEditDate, Version, IsDeleted, CreatedOperatorId) </summary>
    public abstract class BasetEntity
    {
        /// <summary> Идентификатор </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        /// <summary> Дата создания </summary>
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ObjectCreateDate { get; set; }

        /// <summary> Дата изменения </summary>
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ObjectEditDate { get; set; }

        /// <summary> Версия </summary>
 
        public int Version { get; set; }

        /// <summary> Удалено? (1 - удалено, 0 - не удалено) </summary>
  
        public int IsDeleted { get; set; }

        /// <summary> Id оператора, создавшего объект </summary>
 
        public long CreatedOperatorId { get; set; }

        /// <summary> Оператор, создавший объект </summary>
        [JsonIgnore]
        public virtual Operator CreatedOperator { get; set; }
    }
}