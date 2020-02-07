using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentRegisterationWebApp.DAO;
namespace StudentRegisterationWebApp
{
    public partial class RegisterationForm : System.Web.UI.Page
    {
        private DummyCountryData _objDummyData;
        protected void Page_Init(object sender, EventArgs e)
        {
            _objDummyData = new DummyCountryData();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var _allCountries = _objDummyData.getCountries();
                Ddl_Country.Items.Add("Select Country");
                Ddl_State.Items.Add("Select State");
                Ddl_City.Items.Add("Select City");
                foreach (var country in _allCountries)
                {
                    Ddl_Country.Items.Add(country);
                }
            }
        }

        protected void Ddl_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ddl_Country.SelectedIndex > 0)
            {
                Ddl_State.Items.Clear();
                Ddl_City.Items.Clear();
                var _allState = _objDummyData.getStates(Ddl_Country.SelectedValue);
                Ddl_State.Items.Add("Select State");
                Ddl_City.Items.Add("Select City");
                foreach (var state in _allState)
                {
                    Ddl_State.Items.Add(state);
                }
            }
            else
            {
                Ddl_State.Items.Clear();
                Ddl_City.Items.Clear();
                Ddl_State.Items.Add("Select State");
                Ddl_City.Items.Add("Select City");

            }
        }

        protected void Ddl_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ddl_State.SelectedIndex > 0)
            {
                Ddl_City.Items.Clear();
                Ddl_City.Items.Add("Select City");
                var _allCities = _objDummyData.getCities(Ddl_State.SelectedValue);
                foreach (var city in _allCities)
                {
                    Ddl_City.Items.Add(city);
                }
            }
            else
            {
                Ddl_City.Items.Clear();
                Ddl_City.Items.Add("Select City");
            }

        }

        protected void Ddl_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_Reset_Click(object sender, EventArgs e)
        {
            CleartextBoxes(this);
        }
        public void CleartextBoxes(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if ((c.GetType() == typeof(TextBox)))
                {

                    ((TextBox)(c)).Text = "";
                }
                else if (c.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)(c)).Checked = false;
                }

                else if (c.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)(c)).Checked = false;
                }

                else if (c.GetType() == typeof(DropDownList))
                {
                    ((DropDownList)(c)).SelectedIndex= 0;
                }

                if (c.HasControls())
                {
                    CleartextBoxes(c);
                }
            }
        }
    }
}