using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    /// <summary> Муниципальное недвижимое имущество </summary>
    [Table("municipal_immovable_estate")]
    public class MunicipalImmovableEstate : BaseEntity
    {
        /// <summary> Реестровый номер </summary>
        [Column("registry_number")]
        public string RegistryNumber { get; set; }

        /// <summary> Наименование </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary> Адрес (местоположение) </summary>
        [Column("address")]
        public string Address { get; set; }

        /// <summary> Кадастровый номер </summary>
        [Column("cadastral_number")]
        public string CadastralNumber { get; set; }

        /// <summary> Количество штук или погоных метров </summary>
        [Column("running_meter")]
        public decimal? RunningMeter { get; set; }

        /// <summary> Общая площадь (кв.метров) </summary>
        [Column("total_area")]
        public decimal TotalArea { get; set; }

        /// <summary> Полезная площадь (кв.метров) </summary>
        [Column("useful_area")]
        public decimal? UsefulArea { get; set; }

        /// <summary> Количество встроенно-пристроенных помещений </summary>
        [Column("attached_rooms_number")]
        public decimal? AttachedRoomsNumber { get; set; }

        /// <summary> Год ввода (приобретения) </summary>
        [Column("entry_year")]
        public int? EntryYear { get; set; }

        /// <summary> Балансовая (восстановительная) стоимость </summary>
        [Column("balance_cost")]
        public decimal BalanceCost { get; set; }

        /// <summary> Сумма начисленной амортизации </summary>
        [Column("amortization_sum")]
        public decimal? AmortizationSum { get; set; }

        /// <summary> Сведения о кадастровой стоимости недвижимого имущества </summary>
        [Column("cadastral_cost")]
        public decimal CadastralCost { get; set; }

        /// <summary> Дата возникновения и прекращения права муниципальной собственности на движимое имущество </summary>
        [Column("creation_termination_right_date")]
        public DateTime CreationTerminationRightDate { get; set; }

        /// <summary> Основания возникновения (прекращения) права муниципальной собственности на движимое имущество </summary>
        [Column("creation_termination_right_reason")]
        public string CreationTerminationRightReason { get; set; }

        /// <summary> Полное наименование правообладателя </summary>
        [Column("right_holder_full_name")]
        public string RightHolderFullName { get; set; }

        /// <summary> Код ОКПО </summary>
        [Column("okpo_code")]
        public string OKPOCode { get; set; }

        /// <summary> Сведения об установленных в отношении муниципального недвижимого имущества ограничениях (обременениях) с указанием основания и даты их возникновения и прекращения </summary>
        [Column("restriction_information")]
        public string RestrictionInformation { get; set; }

        /// <summary> Остаточная стоимость </summary>
        [Column("residual_cost")]
        public decimal? ResidualCost { get; set; }

        /// <summary> Дата определения остаточной стоимости </summary>
        [Column("residual_cost_determination_date")]
        public DateTime? ResidualCostDeterminationDate { get; set; }

        /// <summary> Инвентарный номер </summary>
        [Column("inventory_number")]
        public string InventoryNumber { get; set; }

        /// <summary> Структурное подразделение </summary>
        [Column("structural_department")]
        public string StructuralDepartment { get; set; }

        /// <summary> Ответственное лицо </summary>
        [Column("responsible_person")]
        public string ResponsiblePerson { get; set; }

        /// <summary> Балансодержатель </summary>
        [Column("balance_holder")]
        public string BalanceHolder { get; set; }

        /// <summary> Первоначальная стоимость объекта </summary>
        [Column("initial_cost")]
        public decimal? InitialCost { get; set; }

        /// <summary> Вид объекта (недвижимое, особо ценное движимое, иное движимое) </summary>
        [Column("object_kind")]
        public string ObjectKind { get; set; }

        /// <summary> Категория </summary>
        [Column("category")]
        public string Category { get; set; }

        /// <summary> Разрешенное использование </summary>
        [Column("permitted_use")]
        public string PermittedUse { get; set; }

        /// <summary> Запрет публикации информации (Запрещена публикации информации?) </summary>
        [Column("is_publishing_prohibited")]
        public bool IsPublishingProhibited { get; set; }
    }
}
