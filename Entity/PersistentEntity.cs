using System;
using System.Text.Json.Serialization;

namespace Entity
{
    /// <summary> Базовая сущность (Id, ObjectCreateDate, ObjectEditDate, Version, IsDeleted, CreatedOperatorId) </summary>
    public abstract class PersistentEntity
    {
        /// <summary> Идентификатор </summary>
        public long Id { get; set; }

        /// <summary> Дата создания </summary>
    
        public DateTime ObjectCreateDate { get; set; }

        /// <summary> Дата изменения </summary>
   
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