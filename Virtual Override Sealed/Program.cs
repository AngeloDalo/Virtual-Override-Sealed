// See httusing System;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente studente1 = new Studente("angelo", "dalo", "5d");
            Insegnante insegnante1 = new Insegnante("angelo2", "dalo2", "1d");
        }
    }
    class Persona
    {
        public string nome;
        public string cognome;
        public Persona(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }
        //VIRTUAL mi permette di far riscrivere metodo
        public virtual void Saluta()
        {
            Console.WriteLine("sono una persona");
        }
    }
    class Insegnante : Persona
    {
        public string materia;
        public Insegnante(string nome, string cognome, string materia) : base(nome, cognome)
        {
            this.materia = materia;
        }
        //OVERRIDE riscrive metodo di Persona
        //SEALED classe che deriva da Insegante non può riscrivere metodo, si può usare anche sulle classi
        public sealed override void Saluta()
        {
            //base.Salute() prende il saluta di persona
            Console.WriteLine("ciao sono un insengante");
        }
        public void Insegna()
        {

        }
    }

    class InsegnanteBallo : Insegnante
    {
        public string canzone;
        public InsegnanteBallo(string nome, string cognome, string materia, string canzone) : base(nome, cognome, materia)
        {
            this.canzone = canzone;
        }
        //public override void Saluta()
        //{
        //    //base.Salute() prende il saluta di persona
        //    Console.WriteLine("ciao sono un insengante di ballo");
        //}
        public void Insegna()
        {

        }
    }

    class Studente : Persona
    {
        public string classe;

        public Studente(string nome, string cognome, string classe) : base(nome, cognome)
        {
            this.classe = classe;
        }
        public override void Saluta()
        {
            //base.Salute() prende il saluta di persona
            Console.WriteLine("ciao sono uno studente");
        }
        public void Studia()
        {

        }
    }
}




