import { useCategory } from './hooks/useCategory';
import { AppRouter } from './router/AppRouter';



function TaskManagment() {

  const { loading } = useCategory();

  return (
    <>
      {!loading && <AppRouter />}
    </>
  )
}

export default TaskManagment;
