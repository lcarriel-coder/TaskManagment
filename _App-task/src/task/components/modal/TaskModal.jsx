import { useMemo, useState, useEffect } from "react";
import { addHours, differenceInSeconds } from "date-fns";

import Swal from "sweetalert2";
import "sweetalert2/dist/sweetalert2.min.css";

import es from "date-fns/locale/es";
import { useTaskStore, useUiStore } from "../../../hooks";
import {
 
  Dialog,
  DialogContent,
  DialogTitle,

} from "@mui/material";
import { CreateOrEdit } from "../form/CreateOrEdit";



export const TaskModal = () => {
  const { isDateModalOpen, closeDateModal } = useUiStore();
  

  const onCloseModal = () => {
    closeDateModal();
  };

 
  return (
    <Dialog open={isDateModalOpen}  onClose={onCloseModal}    maxWidth="sm" fullWidth>
      <DialogTitle id="alert-dialog-title">Tarea</DialogTitle>
      <DialogContent>
        <CreateOrEdit closeDateModal={onCloseModal}/>
      </DialogContent>
    </Dialog>
  );
};
