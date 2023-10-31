import React from "react";
import { Navigate, Route, Routes } from "react-router-dom";
import { Tasks } from "../pages/Tasks";
import { TaskLayout } from "../layout/TaskLayout";

export const TaskRoutes = () => {
  return (
    <TaskLayout>
      <Routes>
        <Route path="/tareas" element={<Tasks />} />
       

        <Route path="/" element={<Navigate to="/tareas" />} />
      </Routes>
    </TaskLayout>
  );
};
