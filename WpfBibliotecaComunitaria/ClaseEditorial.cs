﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WpfBibliotecaComunitaria
{
    public class ClaseEditorial
    {
        public int ID_Marca
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

        public override string ToString()
        {

            return this.Nombre;
        }


        public static async Task<List<ClaseEditorial>> ObtenerEditorialSebastian()
        {

            List<ClaseEditorial> lstMarcas = new List<ClaseEditorial>();


            using (var clientPratt = new HttpClient())
            {

                clientPratt.BaseAddress = new Uri("https://localhost:44376/");


                clientPratt.DefaultRequestHeaders.Accept.Clear();

                clientPratt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage respuestaPratt = await clientPratt.GetAsync("api/Editoriales");


                if (respuestaPratt.IsSuccessStatusCode)
                {

                    lstMarcas = await respuestaPratt.Content.ReadAsAsync<List<ClaseEditorial>>();
                }
            }

            return lstMarcas;
        }

        public static async Task<bool> NuevaEditorialSebastian(ClaseEditorial m)
        {

            using (var clientPratt = new HttpClient())
            {
                clientPratt.BaseAddress = new Uri("https://localhost:44376/");
                clientPratt.DefaultRequestHeaders.Accept.Clear();
                clientPratt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuestaPratt = await clientPratt.PostAsJsonAsync("api/Editoriales", m);
                return respuestaPratt.IsSuccessStatusCode;
            }
        }

        public static async Task<bool> ActualizarEditorialSebastian(ClaseEditorial m)
        {

            using (var clientPratt = new HttpClient())
            {
                clientPratt.BaseAddress = new Uri("https://localhost:44376/");
                clientPratt.DefaultRequestHeaders.Accept.Clear();
                clientPratt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuestaPratt = await clientPratt.PutAsJsonAsync("api/Editoriales/" + m.ID_Marca, m);
                return respuestaPratt.IsSuccessStatusCode;
            }
        }

        public static async Task<bool> EliminarEditorialSebastian(ClaseEditorial m)
        {

            using (var clientPratt = new HttpClient())
            {
                clientPratt.BaseAddress = new Uri("https://localhost:44376/");
                clientPratt.DefaultRequestHeaders.Accept.Clear();
                clientPratt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuestaPratt = await clientPratt.DeleteAsync("api/Editoriales/" + m.ID_Marca);
                return respuestaPratt.IsSuccessStatusCode;
            }



        }
    }
}