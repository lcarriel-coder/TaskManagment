import { Button ,Grid } from "@mui/material";
import { useTaskStore } from "../../../hooks";

export const AddNew = ({openDateModal}) => {

  const { setActiveTask ,userId} = useTaskStore();

  const handleClickNew = () => {
    setActiveTask({
      taskId: "",
      description: "",
      deadlineToFinish: "",
      isCompleted: false,
      userId,
      categoryId: "",
    });
    openDateModal();
  };

  return (
    <>
      <Grid container justifyContent="right" alignItems="right" mt={3} mb={3} >
        <Grid item>
          <Button onClick={handleClickNew} variant="outlined">
            Crear nueva tarea
          </Button>
        </Grid>
      </Grid>
    </>
  );
};
