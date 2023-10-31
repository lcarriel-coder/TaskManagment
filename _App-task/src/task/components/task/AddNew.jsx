import { Button ,Grid } from "@mui/material";
import { useTaskStore } from "../../../hooks";

export const AddNew = ({openDateModal}) => {

  const { setActiveTask } = useTaskStore();

  const handleClickNew = () => {
    setActiveTask({
      taskId: "",
      description: "",
      deadlineToFinish: "",
      isCompleted: false,
      userId: "9411b400-11c1-4c6b-82a3-a73dd8347b63",
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
