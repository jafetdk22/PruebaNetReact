import { BrowserRouter, Routes, Route } from "react-router";
import { GestorContextProvider } from "../../Context";
import { Ventas } from "../Ventas";
import './App.css';

const AppRoutes = () => {
  return (
    <Routes>
      <Route path="/" element={<Ventas />} />
      {/* <Route path="/Productos" element={<Productos />} /> */}
    </Routes>
  );
};


export const App =() => {
  return (
     <GestorContextProvider>
        <BrowserRouter>
        <AppRoutes/>
        </BrowserRouter>
     </GestorContextProvider>
  );
}