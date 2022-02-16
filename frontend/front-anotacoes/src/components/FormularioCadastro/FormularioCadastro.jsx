import React, { Component } from "react";
import "./estilo.css";
import axios from "axios";
class FormularioCadastro extends Component {
  state = {
    nota: []
  }
  constructor() {
    super();
    this.titulo = "";
    this.texto = "";
  }

  _handlerMudancaTitutlo(evento) {
    evento.stopPropagation();
    this.titulo = evento.target.value;
  }

  _handlerMudancaTexto(evento) {
    evento.stopPropagation();
    this.texto = evento.target.value;
  }

  _criarNota(evento) {
    evento.preventDefault();
    evento.stopPropagation();

    axios.post(`https://localhost:5001/api/Anotacoes/criar`, this.nota)
      .then(res => {
        const notaCriada = res.data;
        this.setState({ notaCriada })
        console.log(notaCriada);
        console.log(res);
      })
  }

  render() {
    return (
      <form className="form-cadastro"
        onSubmit={this._criarNota.bind(this)}
      >
        <input
          type="text"
          placeholder="Título"
          className="form-cadastro_input"
          onChange={this.state.titulo}
        />
        <textarea
          rows={15}
          placeholder="Escreva sua nota..."
          className="form-cadastro_input"
          onChange={this.state.texto}
        />
        <button className="form-cadastro_input form-cadastro_submit" onClick={this._criarNota}>
          Criar Nota
        </button>
      </form>
    );
  }
}

export default FormularioCadastro;
