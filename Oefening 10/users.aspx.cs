using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Oefening_10
{
    public partial class Gebruikers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbBox_Vullen();
            }
        }

        protected void lbUsers_SelectedIndexChanged(object sender, EventArgs e) // Void voor het selecteren van de naam.
        {
            visible_true();
            string connectie, sql, naam; // Connectie voor de database die ik later weer benoem
            naam = lbUsers.SelectedItem.Value.ToString();
            connectie = @"Data Source=DESKTOP-TTPM23T\SQLEXPRESS;";
            connectie += "Initial Catalog=introaspdotnet; Integrated Security=true";
            sql = "select * from users where Username=";
            sql += "'" + naam + "'";
            SqlConnection conn = new SqlConnection(connectie);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);//De sql Command die wordt uitgevoerd zodra hij genoemd wordt
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) //Voor elke datarow in de table maakt hij een item aan
            {
                txbNaam.Text = dr["Voornaam"].ToString();
                txbTussenvoegsel.Text = dr["Tussenvoegsel"].ToString();
                txbAchternaam.Text = dr["Achternaam"].ToString();
                txbUsername.Text = dr["Username"].ToString();
                txbPassword.Text = dr["Password"].ToString();
            }
            conn.Close();
        }

        public void lbBox_Vullen()// Void om alles in de Listbox weer te geven
        {
            lbUsers.Items.Clear(); //Listbox leegmaken.
            string connectie; // Connectie voor de database die ik later weer benoem
            connectie = @"Data Source=DESKTOP-TTPM23T\SQLEXPRESS;";
            connectie += "Initial Catalog=introaspdotnet; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectie);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from users", conn);//De sql Command die wordt uitgevoerd zodra hij genoemd wordt
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows) //Voor elke datarow in de table maakt hij een item aan
            {
                string naam = dr["Voornaam"].ToString() + " " + dr["Tussenvoegsel"].ToString() + " " + dr["Achternaam"].ToString();
                lbUsers.Items.Add(new ListItem { Text = naam, Value = dr["Username"].ToString() }); //De items worden toegevoegd vanuit de database en worden naar een string gemaakt
            }
            conn.Close();
        }

        public void gebruiker_Toevoegen() //Aparte void voor het toevoegen van een gebruiker
        {
            string connectie, sql;
            connectie = @"Data Source=DESKTOP-TTPM23T\SQLEXPRESS;";
            connectie += "Initial Catalog=introaspdotnet; Integrated Security=true";
            sql = "Insert into users values (";
            sql += "'" + txbNaam.Text + "',";
            sql += "'" + txbTussenvoegsel.Text + "',";
            sql += "'" + txbAchternaam.Text + "',";
            sql += "'" + txbUsername.Text + "',";
            sql += "'" + txbPassword.Text + "')";
            SqlConnection conn = new SqlConnection(connectie);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int gelukt = cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void gebruiker_Verwijderen() //Aparte void voor het Verwijderen van een gebruiker
        {
            string connectie, sql, naam;
            naam = txbUsername.Text;
            connectie = @"Data Source=DESKTOP-TTPM23T\SQLEXPRESS;";
            connectie += "Initial Catalog=introaspdotnet; Integrated Security=true";
            sql = "delete from users where Username =";
            sql += "'" + txbUsername.Text + "'";
            SqlConnection conn = new SqlConnection(connectie);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public void gebruiker_Updatenn() //Aparte void voor het Updaten van een gebruiker
        {
            string connectie, sql, naam;
            naam = txbUsername.Text;
            connectie = @"Data Source=DESKTOP-TTPM23T\SQLEXPRESS;";
            connectie += "Initial Catalog=introaspdotnet; Integrated Security=true";
            sql = "update users set Voornaam='" + txbNaam.Text + "' ,Tussenvoegsel='" + txbTussenvoegsel.Text + "' ,Achternaam ='" + txbAchternaam.Text + "', Password='" + txbPassword.Text + "' where Username='" + txbUsername.Text + "'";
            SqlConnection conn = new SqlConnection(connectie);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        protected void btnAdd_Click(object sender, EventArgs e) //BtnClick voor add
        {
            if (lblVoornaam.Visible == false)
            {
                visible_true();
            }
            else 
            {
                gebruiker_Toevoegen();
                lbBox_Vullen();
                boxen_Leegmaken();
                visible_False();
            }
        }

        


        protected void btnDel_Click(object sender, EventArgs e)//Void voor de btn_del
        {
            if (lblUsername.Visible == false)
            {
                visible_true();
            }
            else if(lblUsername.Text == "")
            {
                visible_False();
            }
            else
            {
                gebruiker_Verwijderen();
                boxen_Leegmaken();
                visible_False();
                lbBox_Vullen();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblUsername.Visible == false)
            {
                visible_true();
            }
            else if (lblUsername.Text == "")
            {
                visible_False();
            }
            else
            {
                gebruiker_Updatenn();
                boxen_Leegmaken();
                visible_False();
                lbBox_Vullen();
            }
        }

        public void visible_true() // Void om alles weer te geven
        {
            lblAchternaam.Visible = true;
            lblPassword.Visible = true;
            lblTussenvoegsel.Visible = true;
            lblUsername.Visible = true;
            lblVoornaam.Visible = true;
            txbAchternaam.Visible = true;
            txbPassword.Visible = true;
            txbTussenvoegsel.Visible = true;
            txbUsername.Visible = true;
            txbNaam.Visible = true;

        }

        public void visible_False() // Void om Alles weer te sluiten
        {
            lblAchternaam.Visible = false;
            lblPassword.Visible = false;
            lblTussenvoegsel.Visible = false;
            lblUsername.Visible = false;
            lblVoornaam.Visible = false;
            txbAchternaam.Visible = false;
            txbPassword.Visible = false;
            txbTussenvoegsel.Visible = false;
            txbUsername.Visible = false;
            txbNaam.Visible = false;

        }

        public void boxen_Leegmaken() // Void om Alle boxen leeg te maken
        {
            txbAchternaam.Text = "";
            txbPassword.Text = "";
            txbTussenvoegsel.Text = "";
            txbUsername.Text = "";
            txbNaam.Text = "";

        }

       
    }
}