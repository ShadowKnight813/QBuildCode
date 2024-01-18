import React, { useState, useEffect } from "react";
import axios from "axios";
import { TreeView, DataGrid } from "react-bootstrap";

const App = () => {
    const [bomData, setBomData] = useState([]);
    const [partData, setPartData] = useState([]);
    const [selectedPart, setSelectedPart] = useState(null);

    useEffect(() => {
        const fetchData = async () => {
            const bomPromise = axios.get("/api/bom");
            const partPromise = axios.get("/api/part");
            const [bomRes, partRes] = await Promise.all([bomPromise, partPromise]);
            setBomData(bomRes.data);
            setPartData(partRes.data);
        };

        fetchData();
    }, []);

    // ...

    return (
        <div className="App">
            {/* TreeView and DataGrid components */}
        </div>
    );
};

export default App;