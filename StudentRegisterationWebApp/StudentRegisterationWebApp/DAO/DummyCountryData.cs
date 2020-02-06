using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegisterationWebApp.DAO
{
    public class DummyCountryData
    {
        Dictionary<string, List<string>> _countryToState = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> _sateToCity = new Dictionary<string, List<string>>();

        public DummyCountryData()
        {
            _countryToState.Add("India", new List<string>() { "Andhra Pradesh", "Uttar Pradesh", "Haryana", "Punjab" });

            _sateToCity.Add("Andhra Pradesh", new List<string>() { "Vijayawada", "Guntur", "Kadapa", "Tenali" });
            _sateToCity.Add("Uttar Pradesh", new List<string>() { "Kanpur", "Lucknow", "Ghaziabad" });
            _sateToCity.Add("Haryana", new List<string>() { "Ambala", "Karnal" });
            _sateToCity.Add("Punjab", new List<string>() { "Mohali", "Rajpura" });


            _countryToState.Add("China", new List<string>() { "Fujian", "Gansu", "Guangdong" });
            _sateToCity.Add("Fujian", new List<string>() { "Shaowu", "Shishi", "Wuyishan" });
            _sateToCity.Add("Gansu", new List<string>() { "Baiyin", "Dingxi", "Dunhuang" });
            _sateToCity.Add("Guangdong", new List<string>() { "Foshan", "Gaozhou", "Shishi" });

            _countryToState.Add("Nepal", new List<string>() { "Bagmati", "Gandaki", "Sudurpashchim" });

            _sateToCity.Add("Bagmati", new List<string>() { "Kathmandu", "Lalitpur", "Wuyishan" });
            _sateToCity.Add("Gandaki", new List<string>() { "Pokhara", "Baiyin", "Gansu" });
            _sateToCity.Add("Sudurpashchim", new List<string>() { "Mohali", "Karnal", "Vijayawada" });
        }



        public List<string> getCountries() => _countryToState.Keys.ToList();

        public List<string> getStates(string countryName) => _countryToState[countryName];

        public List<string> getCities(string stateName) => _sateToCity[stateName];


    }
}