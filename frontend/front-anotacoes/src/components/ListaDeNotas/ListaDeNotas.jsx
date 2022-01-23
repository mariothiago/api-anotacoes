import React, { Component } from "react";
import CardNota from "../CardNota";
import "./estilo.css";
import axios from 'axios';
class ListaDeNotas extends Component {
  state = {
    notasListadas: []
  }
  componentDidMount() {
    axios.get(`https://localhost:5001/api/Anotacoes/listar-todas`)
      .then(res => {
        const notasListadas = res.data;
        this.setState({ notasListadas })
        console.log(res);
      })
  }
  render() {
    return (
      <ul className="lista-notas">
        {this.state.notasListadas
          .map((nota, index) => {
            return (
              <li className="lista-notas_item" key={index}>
                <CardNota titulo={nota.titulo} texto={nota.texto} />
              </li>
            );
          })}
      </ul>
    );
  }
}

export default ListaDeNotas;
