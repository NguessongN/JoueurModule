using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joueur.BO
{
    public class Joueur
    {
        public string Email { get; set; }
        public string Nom { get; set; }
        public double Score { get; set; }
        private List<Joueur> joueurs;
        public Joueur(string email)
        {
            joueurs = new List<Joueur>();
        }

        public Joueur(string email, string nom, double Score)
        {
            Email = email;
            Nom = nom;
            Score =0;
        }

        public void Addjoueur(Joueur joueur)
        {
            joueurs.Add(joueur);
        }
        public void Removejoueur(Joueur joueur)
        {
            joueurs.Remove(joueur);
        }
        public void Restorejoueur(Joueur joueur)
        {
            joueurs.Restorejoueur(joueur);
        }
        public override bool Equals(object obj)
        {
            return obj is Joueur joueur &&
                   Email == joueur.Email;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(Email);
        }
        public Joueur(Joueur joueur) : this(joueur?.Email, joueur?.Nom, joueur?.Score ?? 0)
        {

        }
    }
}
