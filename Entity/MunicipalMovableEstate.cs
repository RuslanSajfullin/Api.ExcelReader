using System;

namespace Entity
{

    /// <summary> Муниципальное движимое имущество </summary>
    public class MunicipalMovableEstate : PersistentEntity
    {
        /// <summary> Реестровый номер </summary>
        public string RegistryNumber { get; set; }

        /// <summary> Наименование </summary>
        public string Name { get; set; }

        /// <summary> Балансовая (восстановительная) стоимость </summary>
        public decimal BalanceCost { get; set; }

        /// <summary> Сумма начисленной амортизации </summary>
        public decimal? AmortizationSum { get; set; }

        /// <summary> Дата возникновения и прекращения права муниципальной собственности на движимое имущество </summary>
        public DateTime CreationTerminationRightDate { get; set; }

        /// <summary> Реквизиты документов - оснований возникновения (прекращения) права </summary>
        public string CreationTerminationRightReasonDocumentDetails { get; set; }

        /// <summary> Субъект права </summary>
        public string RightSubject { get; set; }

        /// <summary> Полное наименование правообладателя </summary>
        public string RightHolderFullName { get; set; }

        /// <summary> Код ОКПО </summary>
        public string OKPOCode { get; set; }

        /// <summary> Вид права, основание (номер, дата) </summary>
        public string RightType { get; set; }

        /// <summary> Наименование акционерного общества-эмитента, его основном государственном регистрационном номере </summary>
        public string StockCompanyName { get; set; }

        /// <summary> Количество акций, выпущенных акционерным обществом (с указанием  количества привилегированных акций), и размере доли в уставном капитале, принадлежащей муниципальному образованию, в процентах) </summary>
        public string StockNumber { get; set; }

        /// <summary> Номинальная стоимость акций </summary>
        public decimal? NominalStockCost { get; set; }

        /// <summary> Размер уставного (складочного) капитала хозяйственного общества, товарищества и доля муниципального образования в уставном (складочном) капитале в процентах </summary>
        public string AuthorisedCapitalSize { get; set; }

        /// <summary> Наименовании хозяйственного общества, товарищества, его основном государственном регистрационном номере </summary>
        public string PartnershipName { get; set; }

        /// <summary> Материально ответственное лицо </summary>
        public string MateriallyResponsiblePerson { get; set; }

        /// <summary> Кому передан (школа, детский сад) </summary>
        public string TransferredTo { get; set; }

        /// <summary> Остаточная стоимость </summary>
        public decimal ResidualCost { get; set; }

        /// <summary> Дата определения остаточной стоимости </summary>
        public DateTime? ResidualCostDeterminationDate { get; set; }

        /// <summary> Процент износа </summary>
        public decimal? AmortizationPercent { get; set; }

        /// <summary> Структурное подразделение </summary>
        public string StructuralDepartment { get; set; }

        /// <summary> Ответственное лицо </summary>
        public string ResponsiblePerson { get; set; }

        /// <summary> Балансодержатель </summary>
        public string BalanceHolder { get; set; }

        /// <summary> Инвентарный номер </summary>
        public string InventoryNumber { get; set; }

        /// <summary> Первоначальная стоимость объекта </summary>
        public decimal? InitialCost { get; set; }

        /// <summary> Вид объекта (недвижимое, особо ценное движимое, иное движимое) </summary>
        public string ObjectKind { get; set; }

        /// <summary> Категория </summary>
        public string Category { get; set; }

        /// <summary> Разрешенное использование </summary>
        public string PermittedUse { get; set; }

        /// <summary> Дата ввода в эксплуатацию </summary>
        public DateTime? CommissioningDate { get; set; }

        /// <summary> Запрет публикации информации (Запрещена публикации информации?) </summary>
        public bool IsPublishingProhibited { get; set; }
    }
}
