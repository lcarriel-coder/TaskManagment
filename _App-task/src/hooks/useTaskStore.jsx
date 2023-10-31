import { useDispatch, useSelector } from "react-redux";
import Swal from "sweetalert2";
import { taskApi } from "../api";
import {
  onAddNewTask,
  onDeleteTask,
  onLoadingTasks,
  onSetActiveTask,
  onUpdateTask,

  onLoading,

} from "../store";
import { useEffect } from "react";

export const useTaskStore = () => {

  const dispatch = useDispatch();

  const { tasks, activeTask ,isLoadingTask , totalRecords ,pageSize} = useSelector((state) => state.task);

  const setActiveTask = (task) => {
    dispatch(onSetActiveTask(task));
  };




  const startSavingTask= async (task) => {
    

    try {
      if (task?.taskId) {
        // Actualizando
        await taskApi.put(`/task/editTask`, task);
   
        dispatch(onUpdateTask({ ...task, task }));
        return;
      }
      // Creando
      const { data } = await taskApi.post("/task/create", task);

      dispatch(onAddNewTask({ ...task, taskId: data, task }));
    } catch (error) {
      console.log(error);
      Swal.fire("Error al guardar", error.response.data?.msg, "error");
    }
   
  };

  const startDeletingTask= async (taskId) => {
    //
    try {
      const { data } = await taskApi.delete(`/task/DeleteTask/${taskId}`);
      dispatch(onDeleteTask({taskId}));

    } catch (error) {
     
      console.log(error);
      Swal.fire("Error al eliminar", error?.response?.data?.msg, "error");
    }
  };

  const startLoadingTasks = async ({obj}) => {

    dispatch(onLoading());



    try {
      const queryParams = {
        UserId: obj?.UserId,
        Filter: obj?.Filter || '',
        PageNumber: obj?.PageNumber + 1,
        PageSize: pageSize,
    };

 
   
    const queryString = new URLSearchParams(queryParams).toString();
      const { data } = await taskApi.get(`/Task?${queryString}`);

      dispatch(
        onLoadingTasks({
          tasks: data?.listRecords,
          totalPages: data?.totalPages,
          totalRecords: data?.totalRecords,
        })
      );
    } catch (error) {
      console.log("Error cargando tareas");
      console.log(error);
    }
  };




  return {
    //* Propiedades
    isLoadingTask,
    activeTask,
    tasks,
    hasTaskSelected: !!activeTask,
    totalRecords,
    pageSize,

    
    //* Métodos
    startDeletingTask,
    setActiveTask,
    startSavingTask,
    startLoadingTasks,


  };
};
