import PostsList from '../src/features/posts/postsList';
import Addform from './features/posts/addposts';


function App() {
  return (
   <main className="App">
    <Addform/>
    <PostsList/>
   </main>
  );
}

export default App;
