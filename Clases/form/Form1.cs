﻿using Clases.ApiRest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        DBApi dBApi = new DBApi();
        public Form1()
        {
            InitializeComponent();
        }

     
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dBApi.Get("https://reqres.in/api/users?page=1");
            //int id = int.Parse(txtID.Text);
            int id = int.Parse(listBox1.Text);
            pictureBox1.ImageLocation = respuesta.data[id].avatar.ToString();
            txtNombreGET.Text = respuesta.data[id].first_name.ToString();
            txtApellidoGET.Text = respuesta.data[id].last_name.ToString();
            txtEmail.Text = respuesta.data[id].email.ToString();
           
        }

    }

    public class Persona
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}

