import { Grid,Card,CardContent,CardHeader,IconButton,Typography    } from "@mui/material";
import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';
import { useTaskStore} from "../../../hooks";
import { format } from 'date-fns';

export const Task = ({ data, openDateModal }) => {

    const { startDeletingTask, setActiveTask } = useTaskStore();

    const handleClickNew = () => {
      setActiveTask(data);
      openDateModal();
    };
    const handleClickDelete = () => {
      startDeletingTask(data?.taskId);
    };

    const isCompleted = data?.isCompleted;
    const cardClass = isCompleted ? 'completed-card' : '';

  return (
    <>
      <Grid item xs={12} md={4}>
      <Card className={`card-custom ${cardClass}`}>
          <CardHeader
            title={data?.description}
            subheader={format(new Date(data?.deadlineToFinish), 'yyyy-MM-dd')}
            action={
              <>
               <IconButton onClick={() => handleClickNew()}>
              <EditIcon />
            </IconButton>
            <IconButton onClick={() => handleClickDelete()}>
              <DeleteIcon />
            </IconButton>
              </>
            }
          />
          <CardContent>
          <Typography variant="body2" color="textSecondary">
              Categoria: {data?.categoryName }
            </Typography>
            <Typography variant="body2" color="textSecondary">
              Estado Completado: <strong>{data?.isCompleted ? "Sí" : "No"} </strong>
            </Typography>
          </CardContent>
        </Card>
      </Grid>
    </>
  );
};
