namespace Eurosoci.Migrations
{
    using Eurosoci.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Eurosoci.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Eurosoci.Models.ApplicationDbContext context)
        {

            //*************************************
            // adiciona JOGADORES
            var jogadores = new List<Jogadores> {
               new Jogadores {ID=1, Nome=" Rui Freitas", Username="rufino", Email="rufino@gmail.com",  DataNascimento=new DateTime(1968,2,20) },
               new Jogadores {ID=2, Nome="António Rocha", Username="antonio1981", Email="AntonioRocha@hotmail.com",  DataNascimento=new DateTime(1981,7,2) },
               new Jogadores {ID=3, Nome="André Silveira", Username="a.Silveira", Email="andre_Silv@iol.com",  DataNascimento=new DateTime(1977,1,31) },
               new Jogadores {ID=4, Nome="Maria Teixeira", Username="maritei", Email="mariazinha@gmail.com",  DataNascimento=new DateTime(1980,6,15) },
               new Jogadores {ID=5, Nome="Clara Pinto", Username="clarinha", Email="clara1990@gmail.com",  DataNascimento=new DateTime(1990,1,24) },
               new Jogadores {ID=6, Nome="Rui Ferreira", Username="rui_ferreira", Email="rui_ferreira@yahoo.com",  DataNascimento=new DateTime(1981,9,11) },
               new Jogadores {ID=7, Nome="Fábio Ribeiro", Username="tuning", Email="fabituning92@gmail.com",  DataNascimento=new DateTime(1992,12,29) },
               new Jogadores {ID=8, Nome="Augusto Sousa", Username="guguMiCa", Email="AugustoSousa@outlook.pt",  DataNascimento=new DateTime(1974,2,6) },
               new Jogadores {ID=9, Nome="Beatriz Pinto", Username="minorca23", Email="minorca23@iol.com",  DataNascimento=new DateTime(1983,8,19) },
               new Jogadores {ID=10, Nome="José Alves", Username="jomasal", Email="Jose_alves76@yahoo.com",  DataNascimento=new DateTime(1976,5,3) },
            };
            jogadores.ForEach(jj => context.Jogadores.AddOrUpdate(j => j.Nome, jj));
            context.SaveChanges();

            //***************************************
            // adiciona SOCIEDADES
            var sociedades = new List<Sociedades> {
               new Sociedades {ID=1, Nome="Euromilhas", GestorFK=1, DataConstituicao=new DateTime(2017,8,20) },
               new Sociedades {ID=2, Nome="Ricos e famosos", GestorFK=2, DataConstituicao=new DateTime(2018,1,1) },
               new Sociedades {ID=3, Nome="Azarados", GestorFK=5, DataConstituicao=new DateTime(2018,2,28) },
            };
            sociedades.ForEach(ss => context.Sociedades.AddOrUpdate(s => s.Nome, ss));
            context.SaveChanges();

            // adiciona SÓCIOS
            var socios = new List<Jog_Soc> {
             new Jog_Soc {ID=1, JogadorFK=1, SociedadeFK=1,  DataEntrada=new DateTime(2017,8,21)},
             new Jog_Soc {ID=2, JogadorFK=2, SociedadeFK=2,  DataEntrada=new DateTime(2017,2,23)},
             new Jog_Soc {ID=3, JogadorFK=3, SociedadeFK=1,  DataEntrada=new DateTime(2017,10,21), DataSaida=new DateTime(2017,12,31)},
             new Jog_Soc {ID=4, JogadorFK=4, SociedadeFK=1,  DataEntrada=new DateTime(2018,3,1)},
             new Jog_Soc {ID=5, JogadorFK=5, SociedadeFK=3,  DataEntrada=new DateTime(2018,1,24)},
             new Jog_Soc {ID=6, JogadorFK=6, SociedadeFK=2,  DataEntrada=new DateTime(2018,1,29)},
             new Jog_Soc {ID=7, JogadorFK=8, SociedadeFK=2,  DataEntrada=new DateTime(2018,2,6)},
             new Jog_Soc {ID=8, JogadorFK=7, SociedadeFK=1,  DataEntrada=new DateTime(2018,2,19)},
             new Jog_Soc {ID=9, JogadorFK=10, SociedadeFK=3,  DataEntrada=new DateTime(2018,2,3)},
            };
            socios.ForEach(ss => context.Jog_Socs.AddOrUpdate(s => new { s.JogadorFK, s.SociedadeFK }, ss));
            context.SaveChanges();


            // adiciona Numeros
            var numeros = new List<Numeros> {
               new Numeros {ID=1, Valor=1, EEstrela=false},
               new Numeros {ID=2, Valor=2, EEstrela=false},
               new Numeros {ID=3, Valor=3, EEstrela=false},
               new Numeros {ID=4, Valor=4, EEstrela=false},
               new Numeros {ID=5, Valor=5, EEstrela=false},
               new Numeros {ID=6, Valor=6, EEstrela=false},
               new Numeros {ID=7, Valor=7, EEstrela=false},
               new Numeros {ID=8, Valor=8, EEstrela=false},
               new Numeros {ID=9, Valor=9, EEstrela=false},
               new Numeros {ID=10, Valor=10, EEstrela=false},
               new Numeros {ID=11, Valor=11, EEstrela=false},
               new Numeros {ID=12, Valor=12, EEstrela=false},
               new Numeros {ID=13, Valor=13, EEstrela=false},
               new Numeros {ID=14, Valor=14, EEstrela=false},
               new Numeros {ID=15, Valor=15, EEstrela=false},
               new Numeros {ID=16, Valor=16, EEstrela=false},
               new Numeros {ID=17, Valor=17, EEstrela=false},
               new Numeros {ID=18, Valor=18, EEstrela=false},
               new Numeros {ID=19, Valor=19, EEstrela=false},
               new Numeros {ID=20, Valor=20, EEstrela=false},
               new Numeros {ID=21, Valor=21, EEstrela=false},
               new Numeros {ID=22, Valor=22, EEstrela=false},
               new Numeros {ID=23, Valor=23, EEstrela=false},
               new Numeros {ID=24, Valor=24, EEstrela=false},
               new Numeros {ID=25, Valor=25, EEstrela=false},
               new Numeros {ID=26, Valor=26, EEstrela=false},
               new Numeros {ID=27, Valor=27, EEstrela=false},
               new Numeros {ID=28, Valor=28, EEstrela=false},
               new Numeros {ID=29, Valor=29, EEstrela=false},
               new Numeros {ID=30, Valor=30, EEstrela=false},
               new Numeros {ID=31, Valor=31, EEstrela=false},
               new Numeros {ID=32, Valor=32, EEstrela=false},
               new Numeros {ID=33, Valor=33, EEstrela=false},
               new Numeros {ID=34, Valor=34, EEstrela=false},
               new Numeros {ID=35, Valor=35, EEstrela=false},
               new Numeros {ID=36, Valor=36, EEstrela=false},
               new Numeros {ID=37, Valor=37, EEstrela=false},
               new Numeros {ID=38, Valor=38, EEstrela=false},
               new Numeros {ID=39, Valor=39, EEstrela=false},
               new Numeros {ID=40, Valor=40, EEstrela=false},
               new Numeros {ID=41, Valor=41, EEstrela=false},
               new Numeros {ID=42, Valor=42, EEstrela=false},
               new Numeros {ID=43, Valor=43, EEstrela=false},
               new Numeros {ID=44, Valor=44, EEstrela=false},
               new Numeros {ID=45, Valor=45, EEstrela=false},
               new Numeros {ID=46, Valor=46, EEstrela=false},
               new Numeros {ID=47, Valor=47, EEstrela=false},
               new Numeros {ID=48, Valor=48, EEstrela=false},
               new Numeros {ID=49, Valor=49, EEstrela=false},
               new Numeros {ID=50, Valor=50, EEstrela=false},
               new Numeros {ID=51, Valor=1, EEstrela=true},
               new Numeros {ID=52, Valor=2, EEstrela=true},
               new Numeros {ID=53, Valor=3, EEstrela=true},
               new Numeros {ID=54, Valor=4, EEstrela=true},
               new Numeros {ID=55, Valor=5, EEstrela=true},
               new Numeros {ID=56, Valor=6, EEstrela=true},
               new Numeros {ID=57, Valor=7, EEstrela=true},
               new Numeros {ID=58, Valor=8, EEstrela=true},
               new Numeros {ID=59, Valor=9, EEstrela=true},
               new Numeros {ID=60, Valor=10, EEstrela=true},
               new Numeros {ID=61, Valor=11, EEstrela=true},
               new Numeros {ID=62, Valor=12, EEstrela=true},
            };
            numeros.ForEach(nn => context.Numeros.AddOrUpdate(n => new { n.Valor, n.EEstrela }, nn));
            context.SaveChanges();

            // adiciona PAGAMENTOS
            var pagamentos = new List<Pagamentos> {
               new Pagamentos {ID=1, Jog_SocFK=1, ValorPago=5,  DataPagamento=new DateTime(2017,8,21) },
               new Pagamentos {ID=2, Jog_SocFK=2, ValorPago=3,  DataPagamento=new DateTime(2017,2,23) },
               new Pagamentos {ID=3, Jog_SocFK=4, ValorPago=10,  DataPagamento=new DateTime(2017,10,21) },
               new Pagamentos {ID=4, Jog_SocFK=5, ValorPago=4,  DataPagamento=new DateTime(2018,3,1) },
               new Pagamentos {ID=5, Jog_SocFK=3, ValorPago=5,  DataPagamento=new DateTime(2018,1,24) },
               new Pagamentos {ID=6, Jog_SocFK=1, ValorPago=12,  DataPagamento=new DateTime(2018,3,11) },
               new Pagamentos {ID=7, Jog_SocFK=6, ValorPago=4,  DataPagamento=new DateTime(2018,1,29) },
               new Pagamentos {ID=8, Jog_SocFK=7, ValorPago=10,  DataPagamento=new DateTime(2018,2,6) },
               new Pagamentos {ID=9, Jog_SocFK=9, ValorPago=5,  DataPagamento=new DateTime(2018,2,19) },
            };
            pagamentos.ForEach(pp => context.Pagamentos.AddOrUpdate(p => p.ID, pp));
            context.SaveChanges();

            // adiciona TIPOS DE CHAVES
            var tipochaves = new List<TipoChaves> {
               new TipoChaves {ID=1, Tipo="Chave Apostada" },
               new TipoChaves {ID=2, Tipo="Chave Sorteio" },
            };
            tipochaves.ForEach(tt => context.TipoChaves.AddOrUpdate(t => t.Tipo, tt));
            context.SaveChanges();

            // adiciona CHAVES
            var chaves = new List<Chaves> {
               new Chaves {ID=1,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=17}, new Numeros{ID=28}, new Numeros{ID=35}, new Numeros{ID=47}, new Numeros{ID=57}, new Numeros{ID=61}, new Numeros{ID=12}} },
               new Chaves {ID=2,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=8}, new Numeros{ID=16}, new Numeros{ID=40}, new Numeros{ID=43}, new Numeros{ID=55}, new Numeros{ID=58}, new Numeros{ID=3}} },
               new Chaves {ID=3,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=29}, new Numeros{ID=33}, new Numeros{ID=45}, new Numeros{ID=47}, new Numeros{ID=54}, new Numeros{ID=58}, new Numeros{ID=1}} },
               new Chaves {ID=4,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=27}, new Numeros{ID=39}, new Numeros{ID=46}, new Numeros{ID=48}, new Numeros{ID=61}, new Numeros{ID=62}, new Numeros{ID=14}} },
               new Chaves {ID=5,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=25}, new Numeros{ID=34}, new Numeros{ID=48}, new Numeros{ID=50}, new Numeros{ID=56}, new Numeros{ID=57}, new Numeros{ID=5}} },
               new Chaves {ID=6,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=27}, new Numeros{ID=33}, new Numeros{ID=39}, new Numeros{ID=50}, new Numeros{ID=54}, new Numeros{ID=56}, new Numeros{ID=15}} },
               new Chaves {ID=7,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=16}, new Numeros{ID=25}, new Numeros{ID=39}, new Numeros{ID=44}, new Numeros{ID=57}, new Numeros{ID=61}, new Numeros{ID=3}} },
               new Chaves {ID=8,  Preco=null, TipoChaveFK=2,ListaNumeros=new List<Numeros>{new Numeros{ID=23}, new Numeros{ID=28}, new Numeros{ID=30}, new Numeros{ID=44}, new Numeros{ID=53}, new Numeros{ID=57}, new Numeros{ID=20}} },
            };
            chaves.ForEach(cc => context.Chaves.AddOrUpdate(c => c.ID, cc));
            context.SaveChanges();

            // adiciona CONCURSOS
            var concursos = new List<Concursos> {
               new Concursos {ID="26/2018", ChaveFK=1,  DataConcurso=new DateTime(2018,3,30)},
               new Concursos {ID="27/2018", ChaveFK=2,  DataConcurso=new DateTime(2018,4,3)},
               new Concursos {ID="28/2018", ChaveFK=3,  DataConcurso=new DateTime(2018,4,6)},
               new Concursos {ID="29/2018", ChaveFK=4,  DataConcurso=new DateTime(2018,4,10)},
               new Concursos {ID="30/2018", ChaveFK=5,  DataConcurso=new DateTime(2018,4,13)},
               new Concursos {ID="31/2018", ChaveFK=6,  DataConcurso=new DateTime(2018,4,17)},
               new Concursos {ID="32/2018", ChaveFK=7,  DataConcurso=new DateTime(2018,4,20)},
               new Concursos {ID="33/2018", ChaveFK=8,  DataConcurso=new DateTime(2018,4,24)},
               new Concursos {ID="34/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,4,27)},
               new Concursos {ID="35/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,1)},
               new Concursos {ID="36/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,4)},
               new Concursos {ID="37/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,8)},
               new Concursos {ID="38/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,11)},
               new Concursos {ID="39/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,15)},
               new Concursos {ID="40/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,18)},
               new Concursos {ID="41/2018", ChaveFK=null,  DataConcurso=new DateTime(2018,5,22)},
            };
            concursos.ForEach(cc => context.Concursos.AddOrUpdate(c => c.ID, cc));
            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
