using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Dvd_MvcCodeFirst.Models
{
    public class InicializarBanco : DropCreateDatabaseAlways<BancoContexto>
    {
        protected override void Seed(BancoContexto context)
        {
            //Criar alguns dados no banco
            new List<Professor>
            {
                new Professor
                {
                    Nome = "Igor Vilar",
                    Materia = "IOS",
                    Salario = 4000,
                    Telefone = "34156544",
                    TwitterBlog = "@igorcvilar",
                    Disponivel = true,
                    Admisao = new DateTime(2014, 02, 10),
                    Alunos = new List<Aluno>
                    {
                        new Aluno
                        {
                            NomeAluno = "Bruno",
                            Email = "bruno@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscrição = new DateTime(2011, 8, 12)
                        },
                        new Aluno
                        {
                            NomeAluno = "Rafael",
                            Email = "rafael@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscrição = new DateTime(2011, 7, 12)
                        }

                    },
                    Topicos = new List<Topico>
                    {
                        new Topico { Descricao="Topico 1" },
                        new Topico { Descricao="Topico 2" }

                    }
                },
                new Professor
                {
                    Nome = "Claudenir Andrade",
                    Materia = "Linguagem C#",
                    Salario = 6000,
                    Telefone = "34327845",
                    TwitterBlog = "@Claudenir",
                    Disponivel = true,
                    Admisao = new DateTime(2012, 02, 18),
                    Alunos = new List<Aluno>
                    {
                        new Aluno
                        {
                            NomeAluno = "Leticia",
                            Email = "leticia@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscrição = new DateTime(2011, 8, 13)
                        },
                        new Aluno
                        {
                            NomeAluno = "Julien",
                            Email = "julien@msn.com",
                            Aprovado = false,
                            Ano = 2011,
                            Inscrição = new DateTime(2011, 7, 15)
                        },
                         new Aluno
                        {
                            NomeAluno = "Maurice",
                            Email = "maurice@msn.com",
                            Aprovado = false,
                            Ano = 2012,
                            Inscrição = new DateTime(2011, 8, 22)
                        }
                    },
                    Topicos = new List<Topico>
                    {
                        new Topico { Descricao = "Orientação a Objetos" },
                        new Topico { Descricao = "Estrutura de classes" }
                    }
                }
            }.ForEach(p => context.Professsores.Add(p));


            base.Seed(context);
        }
    }
}