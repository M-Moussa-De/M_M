import { ThemeProvider } from '@emotion/react';
import { createTheme, CssBaseline } from '@mui/material';
import { Container } from '@mui/system';
import Catalog from '../../features/catalog/Catalog';
import Header from './Header';

function App() {
	const theme = createTheme({
		palette: {
			mode: 'dark',
		},
	});

	return (
		<ThemeProvider theme={theme}>
			<CssBaseline />
			<Header />
			<Container>
				<Catalog />
			</Container>
		</ThemeProvider>
	);
}

export default App;
