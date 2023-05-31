using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class ReportConstructorPage : BasePage
    {

        public ReportConstructorPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnChevron => driver.FindElement(By.XPath("//button[@aria-label='toggle undefined']"));
        private IWebElement btncheckboxVostochnayaSibir => driver.FindElement(By.XPath("//label[@for='mat-checkbox-213-input']"));
        private IWebElement btnNext => driver.FindElement(By.XPath("//span[text()='Next']"));
        private IWebElement btnToolExport => driver.FindElement(By.XPath("//img[@mattooltip='Экспорт']"));
        private IWebElement btnToolDiagram => driver.FindElement(By.XPath("//img[@mattooltip='Графики']"));
        private IWebElement btnToolTerritory => driver.FindElement(By.XPath("//img[@mattooltip='Территории']"));
        private IWebElement btnExportReport => driver.FindElement(By.XPath("//span[text()=' Экспорт ']"));
        private IWebElement spinner => driver.FindElement(By.XPath("//mat-spinner[@role='progressbar']"));
        private IWebElement ChevronCentralOffice => driver.FindElement(By.XPath("//mat-icon[text()=' chevron_right ']"));
        private IWebElement txtMoscowRegion => driver.FindElement(By.XPath("//div[text()='Московский регион ']"));
        private IWebElement txtMrCr => driver.FindElement(By.XPath("//div[text()='MR+CR ']"));
        private IWebElement txtVersionAlphaMobile => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Количество активных пользователей по версии Alpha ')]"));
        private IWebElement txtActiveUsersByPosition => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Количество активных пользователей по должностям')]"));
        private IWebElement txtWorkExperience => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Распределение по стажу работы')]"));
        private IWebElement txtDoubleVisitStatistics => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Статистика по оцениванию двойных визитов')]"));
        private IWebElement txtDoubleVisitEstimates => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Средние оценки двойных визитов')]"));
        private IWebElement txtFrequencyOfDoubleVisit => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Регулярность двойных визитов')]"));
        private IWebElement txtActualCategoriesPharmacy => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Количество актуальных категорий аптек')]"));
        private IWebElement txtMonthsOfPharmacySurveys => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Месяцы, когда проводились опросы аптек')]"));
        private IWebElement txtMonthsOfActualizationPharmacy => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Месяцы, когда актуализировались категории аптек')]"));
        private IWebElement txtStatisticsDoctorInterview => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Статистика опрошенных врачей')]"));
        private IWebElement txtDoctorContacs => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Заполнение контактов врачей по представительствам')]"));
        private IWebElement txtCategoriesOfDoctors => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Распределение категорий врачей')]"));
        private IWebElement txtActsOnOffice => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Количество претензионных актов по сетям')]"));
        private IWebElement txtActsOnPharmacies => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Количество претензионных актов по сетям - по АС')]"));
        private IWebElement txtDynamicsOfActiveUsers => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Динамика количества активных пользователей')]"));
        private IWebElement txtEventTypes => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Распределение визитов по типам')]"));
        private IWebElement txtTypesOfTerritories => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Распределение территорий по типам')]"));
        private IWebElement txtActiveDoctor => driver.FindElement(By.XPath("//*[name()='tspan'][contains(text(),'Активные сотрудники учреждений')]"));
        private IWebElement btnToolReady => driver.FindElement(By.XPath("//img[@mattooltip='Готово']"));
        private IWebElement btnReadyReport => driver.FindElement(By.XPath("//span[text()='Построить']"));
        private IWebElement elRowGroup => driver.FindElement(By.XPath("//tbody[@role='rowgroup']"));





        public void ClickChevronBtn() => btnChevron.Click();
        public void ClickCheckboxVostochnayaSibir() => btncheckboxVostochnayaSibir.Click();
        public void ClickNextBtn() => btnNext.Click();
        public void ClickToolExportBtn() => btnToolExport.Click();
        public void ClickToolDiagramBtn() => btnToolDiagram.Click();
        public void ClickToolTerritoryBtn() => btnToolTerritory.Click();
        public void ClickExportReportBtn() => btnExportReport.Click();
        public void ClickSpinner() => spinner.Click();
        public void ClickCentralOfficeChevron() => ChevronCentralOffice.Click();
        public void ClickMoscowRegionTxt() => txtMoscowRegion.Click();
        public void ClickMrCrTxt() => txtMrCr.Click();
        public string GetVersionAlphaMobileTxt => txtVersionAlphaMobile.Text;
        public string GetActiveUsersByPositionTxt => txtActiveUsersByPosition.Text;
        public string GetWorkExperienceTxt => txtWorkExperience.Text;
        public string GetDoubleVisitStatisticsTxt => txtDoubleVisitStatistics.Text;
        public string GetDoubleVisitEstimatesTxt => txtDoubleVisitEstimates.Text;
        public string GetFrequencyOfDoubleVisitTxt => txtFrequencyOfDoubleVisit.Text;
        public string GetActualCategoriesPharmacyTxt => txtActualCategoriesPharmacy.Text;
        public string GetMonthsOfPharmacySurveysTxt => txtMonthsOfPharmacySurveys.Text;
        public string GetMonthsOfActualizationPharmacyTxt => txtMonthsOfActualizationPharmacy.Text;
        public string GetStatisticsDoctorInterviewTxt => txtStatisticsDoctorInterview.Text;
        public string GetDoctorContacsTxt => txtDoctorContacs.Text;
        public string GetCategoriesOfDoctorsTxt => txtCategoriesOfDoctors.Text;
        public string GetActsOnOfficeTxt => txtActsOnOffice.Text;
        public string GetActsOnPharmaciesTxt => txtActsOnPharmacies.Text;
        public string GetDynamicsOfActiveUsersTxt => txtDynamicsOfActiveUsers.Text;
        public string GetEventTypesTxt => txtEventTypes.Text;
        public string GetTypesOfTerritoriesTxt => txtTypesOfTerritories.Text;
        public string GetActiveDoctorTxt => txtActiveDoctor.Text;
        public void ClickToolReadybtn() => btnToolReady.Click();
        public void ClickReadyReportbtn() => btnReadyReport.Click();
        public string GetRowGroupEl => elRowGroup.Text;

    }
}