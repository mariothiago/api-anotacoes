import React, { Component } from "react";
import "./estilo.css";
import axios from "axios";
class FormularioCadastro extends Component {
  state = {
    nota: []
  }
  constructor(props) {
    super(props);
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
    const nota = {
      titulo: this.state.titulo,
      texto: this.state.texto
    }

    axios.post(`https://localhost:5001/api/Anotacoes/criar`, this.state)
      .then(res => {
        console.log(res);
      })
  }

  render() {
    return (
      <form className="form-cadastro "
        onSubmit={this._criarNota.bind(this)}
      >
        <input
          type="text"
          placeholder="Título"
          className="form-cadastro_input"
          onChange={this._handlerMudancaTitutlo.bind(this)}
        />
        <textarea
          rows={15}
          placeholder="Escreva sua nota..."
          className="form-cadastro_input"
          onChange={this._handlerMudancaTexto.bind(this)}
        />
        <button className="form-cadastro_input form-cadastro_submit">
          Criar Nota
        </button>
      </form>
    );
  }
}

export default FormularioCadastro;
