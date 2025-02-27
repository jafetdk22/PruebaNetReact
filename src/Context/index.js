import React, { createContext, useState, useEffect } from "react";
import axios from "axios";

export const GestorContext = createContext();

export const GestorContextProvider = ({ children }) => {
    const [facturas, setFacturas] = useState({ });

    const API_URL = "https://localhost:7000/api/Ventas"
    useEffect(() => {
      axios.get(API_URL)
        .then(response => {
          setFacturas(response.data);
        })
        .catch(error => {
          console.error("Error al obtener los datos:", error);
        });
    }, []);

    return (
        <GestorContext.Provider value={{ facturas, setFacturas }}>
          {children}
        </GestorContext.Provider>
    )
}

export default GestorContext;