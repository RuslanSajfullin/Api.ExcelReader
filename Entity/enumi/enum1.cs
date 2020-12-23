using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.enumi
{
   
    public  enum Map1Code : int
    {
        /// <summary>
        /// Реестровый номер
        /// </summary>
        RegistryNumber = 2,

        /// <summary> Наименование </summary>
        Name = 3,

        /// <summary> Балансовая (восстановительная) стоимость </summary>
        BalanceCost = 7,

        /// <summary> Сумма начисленной амортизации </summary>
        AmortizationSum = 9,

        /// <summary> Дата возникновения и прекращения права муниципальной собственности на движимое имущество </summary>
        CreationTerminationRightDate = 10,

        /// <summary> Реквизиты документов - оснований возникновения (прекращения) права </summary>
        CreationTerminationRightReasonDocumentDetails = 11,

        /// <summary> Субъект права </summary>
        RightSubject = 12,

        /// <summary> Полное наименование правообладателя </summary>
        RightHolderFullName = 13,

        /// <summary> Код ОКПО </summary>
        OKPOCode = 14,

        /// <summary> Вид права, основание (номер, дата) </summary>
        RightType = 15,

        /// <summary> Наименование акционерного общества-эмитента, его основном государственном регистрационном номере </summary>
        StockCompanyName = 27,

        /// <summary> Количество акций, выпущенных акционерным обществом (с указанием  количества привилегированных акций), и размере доли в уставном капитале, принадлежащей муниципальному образованию, в процентах) </summary>
        StockNumber = 28,

        /// <summary> Номинальная стоимость акций </summary>
        NominalStockCost = 29,

        /// <summary> Размер уставного (складочного) капитала хозяйственного общества, товарищества и доля муниципального образования в уставном (складочном) капитале в процентах </summary>
        AuthorisedCapitalSize = 30,

        /// <summary> Наименовании хозяйственного общества, товарищества, его основном государственном регистрационном номере </summary>
        PartnershipName = 31,

        /// <summary> Материально ответственное лицо </summary>
        MateriallyResponsiblePerson = 16,

        /// <summary> Кому передан (школа, детский сад) </summary>
        TransferredTo = 17,

        /// <summary> Остаточная стоимость </summary>
        ResidualCost = 8,

        /// <summary> Дата определения остаточной стоимости </summary>
        ResidualCostDeterminationDate = 18,

        /// <summary> Процент износа </summary>
        AmortizationPercent = 19,

        /// <summary> Структурное подразделение </summary>
        StructuralDepartment = 20,

        /// <summary> Ответственное лицо </summary>
        ResponsiblePerson = 21,

        /// <summary> Балансодержатель </summary>
        BalanceHolder = 22,

        /// <summary> Инвентарный номер </summary>
        InventoryNumber = 6,
        /// <summary> Инвентарный номер2 </summary>
        InventoryNumber2 = 23,

        /// <summary> Первоначальная стоимость объекта </summary>
        InitialCost = 24,
     
        /// <summary> Вид объекта (недвижимое, особо ценное движимое, иное движимое) </summary>
        ObjectKind = 25,

        ///// <summary> Категория </summary>
        //Category 

        ///// <summary> Разрешенное использование </summary>
        //PermittedUse 

        /// <summary> Дата ввода в эксплуатацию </summary>
        CommissioningDate = 26,

        ///// <summary> Запрет публикации информации (Запрещена публикации информации?) </summary>
        //IsPublishingProhibited 
    }
}
