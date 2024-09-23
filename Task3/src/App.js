import React from 'react';
import { Provider } from 'react-redux';
import store from './redux/store';
import PostForm from './components/PostForm';
import PostList from './components/PostList';

const App = () => {
   return (
       <Provider store={store}>
           <div>
               <h1>React-Redux Posts</h1>
               <PostForm />
               <PostList />
           </div>
       </Provider>
   );
};

export default App;
