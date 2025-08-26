using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Gerenciador : Form
    {
        //Objetos globais:
        BibliotecaOVNI.OVNI ovni;

        public Gerenciador(BibliotecaOVNI.OVNI ovni) //Obrigatoriamente deve-se iniciar passando um OVNI
        {
            InitializeComponent();
            //"copiando" o OVNI dentro da outra janela para um objeto global:
            this.ovni = ovni;

            // Atualizar as Informações:
            AtualizarInformacoes();

            // Popular o comboBox com os planetas validos:
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);
        }


        public void AtualizarInformacoes()
        {
            lblTripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblAbduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblSituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligado")}";
            lblPlaneta.Text = $"Planeta atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            //Atualizar os botões ligar e desligar:
            btnDesligar.Enabled = ovni.Situacao;
            btnLigar.Enabled = !ovni.Situacao;

            // Ativar/desativar ogrb de acordo com o status da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;

            // Verificar se a nave está na Terra:
            if (ovni.PlanetaAtual == "Terra")
            {
                // Mudar Imagem
                pibTerra.Image = Properties.Resources.pictureBoxTerra;
            }
            else
            {
                
                    pibTerra.Image = null;
               
               
            }

        }


        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O Ovni foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show("O Ovni já está ligado!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as Informações:
            AtualizarInformacoes();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O Ovni foi ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Ovni já está ligado!",
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Atualizar as Informações:
            AtualizarInformacoes();
        }

        private void btnAddTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adicionado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A nave ja está lotada de tripulantes!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();

        }

        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulante removido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel mais remover tripulantes!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();
        }

        private void btnAddAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("Tripulante Abduzido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tripulante não Abduzido!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();
        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("Tripulante Desabduzido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tripulante não Desabduzido!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                // Verificação especial para quando está indo para a Terra
                if (cmbPlanetas.Text.ToUpper() == "TERRA")
                {
                    MessageBox.Show("🚀 Você está viajando para a Terra! Prepare-se para a chegada! 🌍",
                        "Viagem para Terra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você está indo a outro Planeta!",
                        "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Você não fez a viagem ao outro Planeta!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
            {
                MessageBox.Show("Você Retornou ao seu Planeta Natal!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você não retornou ao Planeta!",
                   "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AtualizarInformacoes();
        }
    }

}
