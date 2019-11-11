using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PIM4SEMVER1._0.BLL;
using PIM4SEMVER1._0.DTO;

namespace PIM4SEMVER1._0.GUI
{
    public partial class TelaInicial : Form
    {
        TelaPrincipalBLL tp = new TelaPrincipalBLL();
        ChamadosDTO dtoChamado = new ChamadosDTO();
        TelaPrincipalDTO telaPrincDTO = new TelaPrincipalDTO();
        List<TelaPrincipalDTO> ListaDTOtelaprinc;
        AberturaChamado AberturaChamado;//chama tela abertura de chamado
        ChamadoBLL BuscarChamado;//utilizado para buscar ultimo chamado na tela principal
        private string usuario;
        private string dadosLogin;

        private void Grafico()
        {
            //----------------------------------------------------------
            //Carrega gráfico
            List<string> Listas = new List<string>();

            Listas = tp.ExecutaLedadosBD(); //lista com todos os chamados vindo do select (tem somente aberto e fechado na lista)
            chtGrafico.Series.Clear(); //limpa os modelo do gráfico
            chtGrafico.Legends.Clear(); //limpa as legendas

            int aberto = 0;
            int fechado = 0;
            int total = 0;
            
            aberto = Listas.Where(x => x != null && x.StartsWith("A")).Count(); //Conta todas as strings começando com A , no caso os chamados abertos
            fechado = Listas.Where(x => x != null && x.StartsWith("F")).Count(); //Conta todas as strings começando com F, no caso os chamados fechados
            total = Listas.Count;




            
            chtGrafico.Legends.Add("Chamados"); //cria a legenda do gráfico

            chtGrafico.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table; //
            chtGrafico.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right; //
            chtGrafico.Legends[0].Alignment = StringAlignment.Center; //Alinha no centro
            chtGrafico.Legends[0].Title = "Total de chamados: " + total + ""; // legenda do gráfico
            chtGrafico.Legends[0].BorderColor = Color.Black; //cor da borda


            string seriesname = "Gráfico";
            chtGrafico.Series.Add(seriesname); //cria o gráfico

            chtGrafico.Series[seriesname].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; //define para o tipo pie

            chtGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None; //tira a paleta de cores
            chtGrafico.PaletteCustomColors = new Color[] { Color.CornflowerBlue, Color.LightGreen, Color.Yellow }; //define nova paleta de cores

            chtGrafico.Series[seriesname].Points.AddXY("Abertos: " + aberto + "", aberto); //mostra no gráfico o número de chamados abertos
            chtGrafico.Series[seriesname].Points.AddXY("Fechados: " + fechado + "", fechado); // mostra no gráfico o número de chamados fechados
            chtGrafico.Update(); //atualiza o grafico
        }
        private void CarregaUltimosChamadosAbertos()
            //função que carrega os últimos chamados aberta
        {
            ListaDTOtelaprinc = new List<TelaPrincipalDTO>();
            ListaDTOtelaprinc = tp.RetornaUltimosChamados();

            //verifica se a lista tem menos de 3 chamados abertos, se tiver menos que 3, o exibe essa mensagem para o último
            if (ListaDTOtelaprinc.Count == 2)
            {
                lblResumoDescr1.Text = ListaDTOtelaprinc[0].TelaPrincResumo1.ToString();
                lblnumProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincProto1.ToString();
                lbldataProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincData1.ToString();

                lblResumoDescr2.Text = ListaDTOtelaprinc[1].TelaPrincResumo1.ToString();
                lblnumProtocolo2.Text = ListaDTOtelaprinc[1].TelaPrincProto1.ToString();
                lbldataProtocolo2.Text = ListaDTOtelaprinc[1].TelaPrincData1.ToString();

                
                lblResumoDescr3.Text = "Não existem mais chamados abertos";
                lblnumProtocolo3.Text = "0";
                lbldataProtocolo3.Text = "--/--/--";


            }
            //verifica se a lista tem menos de 3 chamados abertos, se tiver menos que 2, o exibe essa mensagem para o último
            else if (ListaDTOtelaprinc.Count == 1)
            {
                lblResumoDescr1.Text = ListaDTOtelaprinc[0].TelaPrincResumo1.ToString();
                lblnumProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincProto1.ToString();
                lbldataProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincData1.ToString();

                lblResumoDescr2.Text = "Não existem mais chamados abertos";
                lblnumProtocolo2.Text = "0";
                lbldataProtocolo2.Text = "--/--/--";

                lblResumoDescr3.Text = "Não existem mais chamados abertos";
                lblnumProtocolo3.Text = "0";
                lbldataProtocolo3.Text = "--/--/--";

            }
            //verifica se a lista tem menos de 3 chamados abertos, se tiver menos que 1, o exibe essa mensagem para o último
            else if (ListaDTOtelaprinc.Count == 0)
            {


                lblResumoDescr1.Text = "Não existem mais chamados abertos";
                lblnumProtocolo1.Text = "0";
                lbldataProtocolo1.Text = "--/--/--";

                lblResumoDescr2.Text = "Não existem mais chamados abertos";
                lblnumProtocolo2.Text = "0";
                lbldataProtocolo2.Text = "--/--/--";

                lblResumoDescr3.Text = "Não existem mais chamados abertos";
                lblnumProtocolo3.Text = "0";
                lbldataProtocolo3.Text = "--/--/--";


            }
            //se estiver completa (3), preenche tudo
            else if (ListaDTOtelaprinc.Count == 3)
            {
                lblResumoDescr1.Text = ListaDTOtelaprinc[0].TelaPrincResumo1.ToString();
                lblnumProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincProto1.ToString();
                lbldataProtocolo1.Text = ListaDTOtelaprinc[0].TelaPrincData1.ToString();

                lblResumoDescr2.Text = ListaDTOtelaprinc[1].TelaPrincResumo1.ToString();
                lblnumProtocolo2.Text = ListaDTOtelaprinc[1].TelaPrincProto1.ToString();
                lbldataProtocolo2.Text = ListaDTOtelaprinc[1].TelaPrincData1.ToString();

                lblResumoDescr3.Text = ListaDTOtelaprinc[2].TelaPrincResumo1.ToString();
                lblnumProtocolo3.Text = ListaDTOtelaprinc[2].TelaPrincProto1.ToString();
                lbldataProtocolo3.Text = ListaDTOtelaprinc[2].TelaPrincData1.ToString();
            }
        }
        

        public TelaInicial(string usu)
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;


            
            dadosLogin = tp.ExecutaRetornaLogin(usu);
            lblusuarioLog.Text = usu;
            lblNivel.Text = dadosLogin;
            usuario = lblusuarioLog.Text;

            Grafico();

            
        }
        
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            new CadastroCliente(dadosLogin).ShowDialog();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //depois de 1 minuto, gráfico atualiza
            Grafico();
            //carrega os ultimos chamados abertos também
            CarregaUltimosChamadosAbertos();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(dadosLogin == "Admin") //verifica se o usuário logado é admin
            {
                new CadastroFuncionario().ShowDialog();
            }
            else
            {
                MessageBox.Show("Essa função só pode ser acessada por um administrador do sistema","Aviso!");
            }
        }


        private void TelaInicial_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CarregaUltimosChamadosAbertos();
            //inicia o timer que atualiza o gráfico, timer fica sempre rodando e atualiza a cada 1 minuto
            
        }

        private void btnGerenciarChamado_Click(object sender, EventArgs e)
        {
            new AberturaChamado(usuario,dadosLogin).ShowDialog();
            
        }

        private void btnGerenciarEquipamentos_Click(object sender, EventArgs e)
        {
            if (dadosLogin == "Admin" || dadosLogin == "Técnico") //verifica se o usuário logado é admin
            {
                new CadastroEquipamento().ShowDialog();
            }
            else
            {
                MessageBox.Show("Essa função só pode ser acessada por um administrador do sistema", "Aviso!");
            }
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AjudaTelaInicial().ShowDialog();
        }

        private void btnBuscarChamado_Click(object sender, EventArgs e)
        {
            new BuscaCliente(usuario).ShowDialog();//inicia tela de buscar chamados relacionados a clientes
        }

        private void smSair_Click(object sender, EventArgs e)
        {
            //pergunta se deseja mesmo sair
            DialogResult AtivarCliente = MessageBox.Show("Deseja realmente sair ?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (AtivarCliente.ToString().ToUpper() == "YES")
            {
                Application.Exit();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Pergunta se quer relogar, se sim, reinicial o programa
            DialogResult AtivarCliente = MessageBox.Show("Deseja realmente relogar ?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (AtivarCliente.ToString().ToUpper() == "YES")
            {
                Application.Restart(); //se sim, reinicia a aplicação
            }
        }

        private void ValidaUltimosChamados () 
            //função responsável por verificar se o cliente está ativo
        {
            
                if (dtoChamado.ChamadoSituaCliente == "desativado")
                {
                    MessageBox.Show("Cliente Desativado\nContacte o administrador do sistema", "Aviso!");
                }
                else
                {
                    AberturaChamado = new AberturaChamado(dtoChamado, usuario);
                    AberturaChamado.ShowDialog();
                    CarregaUltimosChamadosAbertos();
                    /*depois que a tela de alteração de chamado for fechada, carrega gráfico e ultimos chamados
                    sem ter que esperar o timer ( 1 minuto) */
                    CarregaUltimosChamadosAbertos();
                    Grafico();
                }
            
        }
        private void btnVerChamado1_Click(object sender, EventArgs e)
        {
            BuscarChamado = new ChamadoBLL();
            CarregaUltimosChamadosAbertos();
            dtoChamado = tp.CarregaUltimoChamado(Convert.ToInt32(lblnumProtocolo1.Text));

            if (lblnumProtocolo1.Text == "0")
                //se protocolo = 0, chamado vázio
            {
                MessageBox.Show("Não existem chamados antigos relacionados", "Aviso!");
            }
            else
            {
                ValidaUltimosChamados();
            }
        }

        private void btnVerChamado2_Click(object sender, EventArgs e)
        {
            BuscarChamado = new ChamadoBLL();
            CarregaUltimosChamadosAbertos();
            dtoChamado = tp.CarregaUltimoChamado(Convert.ToInt32(lblnumProtocolo2.Text));
            if (lblnumProtocolo2.Text == "0")
            {
                MessageBox.Show("Não existem chamados antigos relacionados", "Aviso!");
            }
            else
            {
                ValidaUltimosChamados();
            }
        }

        private void btnVerChamado3_Click(object sender, EventArgs e) //fazer verificação de se protocolo = 0
        {
            BuscarChamado = new ChamadoBLL();
            CarregaUltimosChamadosAbertos();
            dtoChamado = tp.CarregaUltimoChamado(Convert.ToInt32(lblnumProtocolo3.Text));

            if (lblnumProtocolo3.Text == "0")
            {
                MessageBox.Show("Não existem chamados antigos relacionados", "Aviso!");
            }
            else
            {
                ValidaUltimosChamados();
            }
        }

        private void lupaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como Operar a LUPA:\n\nSeta pra cima aumenta\nSeta para baixo diminui\nESC volta");
            //new lupa().ShowDialog();
            lupa lupa = new lupa();
            lupa.Show(this);
        }
    }
}
