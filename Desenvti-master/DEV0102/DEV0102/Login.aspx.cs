﻿using DEV0102.DAL;
using DEV0102.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEV0102
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CodigoUsuario"] != null)
            {
                //Session.Remove("CodigoUsuario");
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            usuarioDAL uDal = new usuarioDAL();

            tabUsuario objUsuario = new tabUsuario();

            objUsuario = uDal.consultarEmaileSenha(txtEmail.Text, txtSenha.Text);

            if (objUsuario == null)
            {
                ExibirAlerta("Usuário ou senha inválido");
            }
            else
            {
                Session.Add("CodigoUsuario", objUsuario.codigo);
                Response.Redirect("Home.aspx");
            }
        }

        public void ExibirAlerta(string varmsg)
        {
            Response.Write("<script>alert('" + varmsg + "')</script>");
        }

        protected void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            usuarioDAL uDal = new usuarioDAL();
            tabUsuario objUsuario = new tabUsuario();

            objUsuario = uDal.consultarUsuarioPorEmail(txtEmail.Text);

            if (objUsuario == null)
            {
                ExibirAlerta("Email não existe na nossa base");
            }
            else
            {
                Suporte sup = new Suporte();
                sup.EnviarEmail("Recuperação de Senha", txtEmail.Text, "A sua senha é " + objUsuario.senha);
                ExibirAlerta("Email enviado, verifique sua caixa de entrada");
            }

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadUsuario.aspx?Cadastro=Novo");
        }
    }
}