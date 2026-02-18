import { defineConfig } from 'vite';

export default defineConfig({
  root: '.',
  publicDir: 'wwwroot',
  server: {
    port: 5173,
    open: true,
    proxy: {
      '/api': {
        target: 'http://localhost:5000',
        changeOrigin: true
      }
    }
  },
  build: {
    outDir: 'wwwroot/dist',
    emptyOutDir: true,
    rollupOptions: {
      input: 'index.html'
    }
  }
});
