using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital.Models;

namespace PontoDigital.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Cliente.csv";
        private const string PATH_INDEX = "Database/Cliente_Id.csv";
        private List<Cliente> clientes = new List<Cliente>();

        public bool Inserir (Cliente cliente) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (cliente);
            File.AppendAllText (PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV (Cliente cliente) {
            return $"id={CONT};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};data_nascimento={cliente.DataNascimento}\n";
        }

        public Cliente ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString(), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public Cliente ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (email.Equals (ExtrairCampo ("email", item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        private Cliente ConverterEmObjeto (string registro) {

            Cliente cliente = new Cliente();
            System.Console.WriteLine("REGISTRO:" + registro);
            cliente.Id = ulong.Parse(ExtrairCampo("id", registro));
            cliente.Nome = ExtrairCampo("nome", registro);
            cliente.Email = ExtrairCampo("email", registro);
            cliente.Senha = ExtrairCampo("senha", registro);
            cliente.DataNascimento = DateTime.Parse(ExtrairCampo("data_nascimento", registro));

            return cliente;
        }

        public List<Cliente> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Cliente cliente = ConverterEmObjeto (item);

                this.clientes.Add (cliente);
            }
            return this.clientes;
        }
    }
}