﻿using BibliotecaDominio.Entidades.ObjetosValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaDominio.Entidades
{
    public class Pessoa
    { 
        public int PessoaId { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; internal set; }

        [Required]
        [CPF]
        public string Cpf { get; internal set; }

        [Required]
        public DateTime DataDeNascimento { get; internal set; }

        public int Idade { get; internal set; }

        public int EnderecoId { get; set; }

        public int DadosLoginId { get; set; }

        public string Profissao { get; internal set; }

        public string Telefone { get; internal set; }

        //[Required]
        public string Email { get; internal set; }

        public virtual DadosLogin Login { get; set; }

        public virtual Endereco Endereco { get; internal set; } //FK de Endereco

        public virtual IEnumerable<Emprestimo> Emprestimo { get; set; }

        public Pessoa()
        {

        }
        public Pessoa(int pessoaId, string nome, string cpf, int enderecoId, int dadosLoginId)
        {
            PessoaId = pessoaId;
            Nome = nome;
            Cpf = cpf;
            EnderecoId = enderecoId;
            DadosLoginId = dadosLoginId;
        }

        public bool ValidaData(Pessoa pessoa)
        {
            var dataAtual = DateTime.Now;
            int resultado = DateTime.Compare(pessoa.DataDeNascimento, dataAtual);

            if (resultado < 0 || resultado == 0)
            {
                return true;
            }
            return false;
        }
    }
}
