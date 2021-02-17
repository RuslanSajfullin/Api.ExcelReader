using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    /// <summary> Муниципальное движимое имущество </summary>
    [Table("municipal_movable_estate")]
    public class MunicipalMovableEstate : BaseEntity
    {
        /// <summary> Реестровый номер </summary>
        [Column("registry_number")]
        public string RegistryNumber { get; set; }

        /// <summary> Наименование </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary> Балансовая (восстановительная) стоимость </summary>
        [Column("balance_cost")]
        public decimal BalanceCost { get; set; }

        /// <summary> Сумма начисленной амортизации </summary>
        [Column("amortization_sum")]
        public decimal? AmortizationSum { get; set; }

        /// <summary> Дата возникновения и прекращения права муниципальной собственности на движимое имущество </summary>
        [Column("creation_termination_right_date")]
        public DateTime CreationTerminationRightDate { get; set; }

        /// <summary> Реквизиты документов - оснований возникновения (прекращения) права </summary>
        [Column("creation_termination_right_reason_document_details")]
        public string CreationTerminationRightReasonDocumentDetails { get; set; }

        /// <summary> Субъект права </summary>
        [Column("right_subject")]
        public string RightSubject { get; set; }

        /// <summary> Полное наименование правообладателя </summary>
        [Column("right_holder_full_name")]
        public string RightHolderFullName { get; set; }

        /// <summary> Код ОКПО </summary>
        [Column("okpo_code")]
        public string OKPOCode { get; set; }

        /// <summary> Вид права, основание (номер, дата) </summary>
        [Column("right_type")]
        public string RightType { get; set; }

        /// <summary> Наименование акционерного общества-эмитента, его основном государственном регистрационном номере </summary>
        [Column("stock_company_name")]
        public string StockCompanyName { get; set; }

        /// <summary> Количество акций, выпущенных акционерным обществом (с указанием  количества привилегированных акций), и размере доли в уставном капитале, принадлежащей муниципальному образованию, в процентах) </summary>
        [Column("stock_number")]
        public string StockNumber { get; set; }

        /// <summary> Номинальная стоимость акций </summary>
        [Column("nominal_stock_cost")]
        public decimal? NominalStockCost { get; set; }

        /// <summary> Размер уставного (складочного) капитала хозяйственного общества, товарищества и доля муниципального образования в уставном (складочном) капитале в процентах </summary>
        [Column("authorised_capital_size")]
        public string AuthorisedCapitalSize { get; set; }

        /// <summary> Наименовании хозяйственного общества, товарищества, его основном государственном регистрационном номере </summary>
        [Column("partnership_name")]
        public string PartnershipName { get; set; }

        /// <summary> Материально ответственное лицо </summary>
        [Column("materially_responsible_person")]
        public string MateriallyResponsiblePerson { get; set; }

        /// <summary> Кому передан (школа, детский сад) </summary>
        [Column("transferred_to")]
        public string TransferredTo { get; set; }

        /// <summary> Остаточная стоимость </summary>
        [Column("residual_cost")]
        public decimal ResidualCost { get; set; }

        /// <summary> Дата определения остаточной стоимости </summary>
        [Column("residual_cost_determination_date")]
        public DateTime? ResidualCostDeterminationDate { get; set; }

        /// <summary> Процент износа </summary>
        [Column("amortization_percent")]
        public decimal? AmortizationPercent { get; set; }

        /// <summary> Структурное подразделение </summary>
        [Column("structural_department")]
        public string StructuralDepartment { get; set; }

        /// <summary> Ответственное лицо </summary>
        [Column("responsible_person")]
        public string ResponsiblePerson { get; set; }

        /// <summary> Балансодержатель </summary>
        [Column("balance_holder")]
        public string BalanceHolder { get; set; }

        /// <summary> Инвентарный номер </summary>
        [Column("inventory_number")]
        public string InventoryNumber { get; set; }

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

        /// <summary> Дата ввода в эксплуатацию </summary>
        [Column("commissioning_date")]
        public DateTime? CommissioningDate { get; set; }

        /// <summary> Запрет публикации информации (Запрещена публикации информации?) </summary>
        [Column("is_publishing_prohibited")]
        public bool IsPublishingProhibited { get; set; }

        /// <summary> Адрес (местоположение) </summary>
        [Column("address")]
        public string Address { get; set; }

        /// <summary> Количество штук или погоных метров </summary>
        [Column("running_meter")]
        public decimal? RunningMeter { get; set; }
    }
}
