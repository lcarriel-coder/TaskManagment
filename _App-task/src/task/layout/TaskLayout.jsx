import { Footer ,Header} from "../components/ui";


export const TaskLayout = ({ children }) => {
  return (
    <>
      <Header />
      {children}
      <Footer />
    </>
  );
};
