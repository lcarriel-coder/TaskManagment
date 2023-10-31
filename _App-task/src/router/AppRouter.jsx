import { Routes,Route  } from "react-router-dom"
import { TaskRoutes } from "../task/routes/TaskRoutes"


export const AppRouter = () => {
  return (
    <Routes>
        
        <Route path="/*" element={<TaskRoutes />} />

    </Routes>
  )
}
