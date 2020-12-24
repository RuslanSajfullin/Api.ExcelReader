using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entity
{
    /// <summary> Базовая сущность (Id, ObjectCreateDate, ObjectEditDate, Version, IsDeleted, CreatedOperatorId) </summary>
    public abstract class BaseEntity
    {
        /// <summary> Идентификатор </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        /// <summary> Дата создания </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("object_create_date")]
        public DateTime ObjectCreateDate { get; set; }

        /// <summary> Дата изменения </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("object_edit_date")]
        public DateTime ObjectEditDate { get; set; }

        /// <summary> Версия </summary>
        [Column("version")]
        public int Version { get; set; }

        /// <summary> Удалено? (1 - удалено, 0 - не удалено) </summary>
        [Column("is_deleted")]
        public int IsDeleted { get; set; }
   
        /// <summary> Оператор, создавший объект </summary>
        [JsonIgnore]
        [Column("operator_id")]
        public virtual Operator CreatedOperator { get; set; }
    }
}