import React, { useContext } from 'react';
import { GestorContext } from '../../Context';

export const Ventas = () => {
  const { facturas } = useContext(GestorContext);

  return (
    <div>
      <h1>Ventas</h1>
      {facturas && facturas.length > 0 ? (
        <table>
          <thead>
            <tr>
              <th>ID Factura</th>
              <th>Número de Factura</th>
              <th>Fecha</th>
              <th>Total</th>
              <th>Productos Adquiridos</th>
            </tr>
          </thead>
          <tbody>
            {facturas.map(factura => (
              <tr key={factura.idFactura}>
                <td>{factura.idFactura}</td>
                <td>{factura.numeroFactura}</td>
                <td>{new Date(factura.fecha).toLocaleDateString()}</td>
                <td>{factura.total}</td>
                <td>{factura.productosAdquiridos}</td>
              </tr>
            ))}
          </tbody>
        </table>
      ) : (
        <p>No hay datos disponibles.</p>
      )}
    </div>
  );
};
