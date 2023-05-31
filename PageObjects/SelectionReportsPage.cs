using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class SelectionReportsPage : BasePage
    {
        public SelectionReportsPage(IWebDriver driver) : base(driver) 
        { 
        
        }

        private IWebElement btnReportstWithoutAGroup => driver.FindElement(By.XPath("//span[text()='Без группы ']"));
        private IWebElement btnPersonalDataProcessing => driver.FindElement(By.XPath("//mat-card-title[text()='Согласия на обработку персональных данных - врачи']"));

        private IWebElement btnUserPassport => driver.FindElement(By.XPath("//mat-card-title[text()='User Passport']"));

        ///private IWebElement btnUserPassport => driver.FindElement(By.XPath("//mat-card-title[text()='Паспорт пользователя']"));   ///для боевого
        private IWebElement btnDoubleVisits => driver.FindElement(By.XPath("//mat-card-title[text()='Двойные визиты']"));
        private IWebElement btnPharmacySurvey => driver.FindElement(By.XPath("//mat-card-title[text()='Опрос аптек']"));
        private IWebElement btnSurveyOfDoctors => driver.FindElement(By.XPath("//mat-card-title[text()='Опрос врачей']"));
        private IWebElement btnDoctorContacts => driver.FindElement(By.XPath("//mat-card-title[text()='Контакты специалистов']"));
        private IWebElement btnContract => driver.FindElement(By.XPath("//mat-card-title[text()='Соблюдение условий контракта']"));
        private IWebElement btnCategorizationOfDoctors => driver.FindElement(By.XPath("//mat-card-title[text()='Отчёт по категоризации врачей']"));
        private IWebElement btnActivityAnalytics => driver.FindElement(By.XPath("//mat-card-title[text()='Аналитика деятельности пользователей']"));
        private IWebElement btnBudapestReports => driver.FindElement(By.XPath("//span[text()='Отчёты для Будапешта ']"));
        private IWebElement btnUnloadingUsers => driver.FindElement(By.XPath("//mat-card-title[text()='Выгрузка пользователей']"));
        private IWebElement btnClients => driver.FindElement(By.XPath("//mat-card-title[text()='Клиенты']"));
        private IWebElement btnClassificationClients => driver.FindElement(By.XPath("//mat-card-title[text()='Классификация клиентов']"));
        private IWebElement btnVisitInformation => driver.FindElement(By.XPath("//mat-card-title[text()='Информация о визитах']"));
        private IWebElement btnActivityInformation => driver.FindElement(By.XPath("//mat-card-title[text()='Информация об активности']"));
        private IWebElement btnCyclePlanData => driver.FindElement(By.XPath("//mat-card-title[text()='Информация по кратности врачей']"));
        private IWebElement btnBudapestKPIReport => driver.FindElement(By.XPath("//mat-card-title[text()='Budapest KPI report']"));
        private IWebElement btnDoctorsPreparats => driver.FindElement(By.XPath("//span[text()='Покрытие врачей по препаратам ']"));
        private IWebElement btnProductEvents => driver.FindElement(By.XPath("//mat-card-title[text()='Количество визитов по препаратам']"));
        private IWebElement btnVisitedProfiles => driver.FindElement(By.XPath("//mat-card-title[text()='Посещаемые профили врачей']"));
        private IWebElement btnActiveUsers => driver.FindElement(By.XPath("//mat-card-title[text()='Количество активных пользователей']"));
        private IWebElement btnUsersEventsCount => driver.FindElement(By.XPath("//mat-card-title[text()='Распределение визитов по типам']"));
        private IWebElement btnTerritoriesTypesCount => driver.FindElement(By.XPath("//mat-card-title[text()='Распределение территорий по типам']"));
        private IWebElement btnDoctorPassport => driver.FindElement(By.XPath("//mat-card-title[text()='Паспорт сотрудника учреждения']"));
        private IWebElement btnForAdministrativeUse => driver.FindElement(By.XPath("//span[text()='Для служебного пользования ']"));
        private IWebElement btnAuditVisits => driver.FindElement(By.XPath("//mat-card-title[text()='Визитные аудиты']"));
        private IWebElement btnEventTracking => driver.FindElement(By.XPath("//mat-card-title[text()='Отчет по изменениям в планировании событий']"));
        private IWebElement btnVisits => driver.FindElement(By.XPath("//span[text()='Визиты ']"));




        public void ClickReportWithoutAGroupBtn() => btnReportstWithoutAGroup.Click();
        public void ClickPersonalDataProcessingBtn() => btnPersonalDataProcessing.Click();
        public void ClickUserPassportBtn() => btnUserPassport.Click();
        public void ClickDoubleVisitsBtn() => btnDoubleVisits.Click();
        public void ClickDoctorContactsBtn() => btnDoctorContacts.Click();
        public void ClickPharmacySurveyBtn() => btnPharmacySurvey.Click();
        public void ClickSurveyOfDoctorsBtn() => btnSurveyOfDoctors.Click();
        public void ClickContractBtn() => btnContract.Click();
        public void ClickCategorizationOfDoctorsBtn() => btnCategorizationOfDoctors.Click();
        public void ClickActivityAnalyticsBtn() => btnActivityAnalytics.Click();
        public void ClickBudapestReportsBtn() => btnBudapestReports.Click();
        public void ClickUnloadingUsersBtn() => btnUnloadingUsers.Click();
        public void ClickClientsBtn() => btnClients.Click();
        public void ClickClassificationClientsBtn() => btnClassificationClients.Click();
        public void ClickCVisitInformationBtn() => btnVisitInformation.Click();
        public void ClickCActivityInformationBtn() => btnActivityInformation.Click();
        public void ClickCyclePlanDataBtn() => btnCyclePlanData.Click();
        public void ClickBudapestKPIReportBtn() => btnBudapestKPIReport.Click();
        public void ClickDoctorsPreparatsBtn() => btnDoctorsPreparats.Click();
        public void ClickProductEventsBtn() => btnProductEvents.Click();
        public void ClickVisitedProfilesBtn() => btnVisitedProfiles.Click();
        public void ClickActiveUsersBtn() => btnActiveUsers.Click();
        public void ClickForAdministrativeUseBtn() => btnForAdministrativeUse.Click();
        public void ClickUsersEventsCountBtn() => btnUsersEventsCount.Click();
        public void ClickTerritoriesTypesCountBtn() => btnTerritoriesTypesCount.Click();
        public void ClickDoctorPassportBtn() => btnDoctorPassport.Click();
        public void ClickVisitsBtn() => btnVisits.Click();
        public void ClickAuditVisitsBtn() => btnAuditVisits.Click();
        public void ClickEventTracking() => btnEventTracking.Click();

       
    }
}
